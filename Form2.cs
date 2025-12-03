using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;  // <-- VERY IMPORTANT

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        // Avatar system
        private AvatarDrawable avatar;
        private Timer avatarTimer;   // <-- FIXED

        // Network
        private string userName;
        private string serverIP;
        private int basePort;
        private int udpPort;
        private int tcpPort;

        private UdpClient udpClient;
        private bool isReceivingVideo = false;
        private CancellationTokenSource cts;

        private TcpClient tcpClient;
        private NetworkStream tcpStream;
        private bool isConnected = false;


        public Form2(string userName, string serverIP, int port)
        {
            InitializeComponent();

            // Remove caret blinking in chat history
            richTextBox1.ReadOnly = true;
            richTextBox1.TabStop = false;
            richTextBox1.GotFocus += (s, e) => HideCaret(richTextBox1.Handle);

            this.userName = userName;
            this.serverIP = serverIP;
            this.basePort = port;
            this.udpPort = port;
            this.tcpPort = port + 1;

            this.Load += Form2_Load;
        }


        private async void Form2_Load(object sender, EventArgs e)
        {
            SetupAvatarSystem();
            richTextBox2.KeyDown += richTextBox2_KeyDown;
            await ConnectToServer();
        }

        // -------------------------------------------------------
        //               AVATAR INITIALIZATION
        // -------------------------------------------------------
        private void SetupAvatarSystem()
        {
            avatar = new AvatarDrawable();

            avatarTimer = new Timer();       // <-- FIXED
            avatarTimer.Interval = 33;       // 30 FPS
            avatarTimer.Tick += (s, e) =>
            {
                avatar.Update();             // blink, talking animation
                panel2.Invalidate();         // redraw avatar
            };
            avatarTimer.Start();

            panel2.Paint += (s, e) =>
            {
                avatar.Draw(e.Graphics);
            };
        }



        // -------------------------------------------------------
        //                   TCP CONNECT
        // -------------------------------------------------------
        private async Task ConnectToServer()
        {
            try
            {
                tcpClient = new TcpClient();
                var timeout = new CancellationTokenSource(5000);

                await tcpClient.ConnectAsync(serverIP, tcpPort).WaitAsync(timeout.Token);

                tcpStream = tcpClient.GetStream();
                isConnected = true;

                // Send username
                byte[] nameData = Encoding.UTF8.GetBytes($"NAME:{userName}");
                await tcpStream.WriteAsync(nameData, 0, nameData.Length);

                _ = Task.Run(() => ReceiveTcpMessages());
                StartVideoReceiver();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed:\n" + ex.Message);
            }
        }


        // -------------------------------------------------------
        //                   UDP VIDEO RECEIVE
        // -------------------------------------------------------
        private void StartVideoReceiver()
        {
            try
            {
                cts = new CancellationTokenSource();
                isReceivingVideo = true;

                udpClient = new UdpClient(udpPort);
                udpClient.Client.ReceiveTimeout = 5000;

                Task.Run(() => ReceiveVideoLoop(cts.Token));
            }
            catch (Exception ex)
            {
                AddMessage("UDP Init error: " + ex.Message, Color.Red);
            }
        }


        private async Task ReceiveVideoLoop(CancellationToken token)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);

            while (!token.IsCancellationRequested && isReceivingVideo)
            {
                try
                {
                    UdpReceiveResult result = await udpClient.ReceiveAsync();
                    byte[] jpegData = result.Buffer;

                    if (jpegData.Length > 100)
                    {
                        DisplayFrame(jpegData);
                    }
                }
                catch { }
            }
        }


        private void DisplayFrame(byte[] data)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    Image img = Image.FromStream(ms);

                    if (pictureBox1.InvokeRequired)
                    {
                        pictureBox1.Invoke(new Action(() =>
                        {
                            pictureBox1.Image?.Dispose();
                            pictureBox1.Image = (Image)img.Clone();
                        }));
                    }
                    else
                    {
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = (Image)img.Clone();
                    }
                }
            }
            catch { }
        }


        // -------------------------------------------------------
        //                   TCP MESSAGING
        // -------------------------------------------------------
        private async Task ReceiveTcpMessages()
        {
            byte[] buffer = new byte[4096];

            try
            {
                while (isConnected && tcpClient.Connected)
                {
                    int bytes = await tcpStream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytes == 0) break;

                    string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
                    AddMessage(msg, Color.Black);

                    // auto mouth open/close
                    avatar.SetTalking(msg.Contains("TALK"));
                }
            }
            catch { }
        }


        private async Task SendMessage(string msg)
        {
            if (!isConnected || string.IsNullOrWhiteSpace(msg))
                return;

            try
            {
                byte[] data = Encoding.UTF8.GetBytes(msg);
                await tcpStream.WriteAsync(data, 0, data.Length);

                AddMessage($"[{userName}] {msg}", Color.Blue);
            }
            catch { }
        }


        private void AddMessage(string msg, Color c)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action(() => AddMessage(msg, c)));
                return;
            }

            richTextBox1.SelectionColor = c;
            richTextBox1.AppendText(msg + "\n");
            richTextBox1.ScrollToCaret();
        }


        // -------------------------------------------------------
        //                   UI BUTTONS
        // -------------------------------------------------------
        private async void button1_Click(object sender, EventArgs e)
        {
            await SendMessage(richTextBox2.Text.Trim());
            richTextBox2.Clear();
        }


        private async void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                await SendMessage(richTextBox2.Text.Trim());
                richTextBox2.Clear();
            }
        }


        // -------------------------------------------------------
        //                   CLEANUP
        // -------------------------------------------------------
        private void Disconnect()
        {
            isConnected = false;
            isReceivingVideo = false;

            cts?.Cancel();
            tcpStream?.Close();
            tcpClient?.Close();
            udpClient?.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Disconnect();
            base.OnFormClosing(e);
        }
    }
}
