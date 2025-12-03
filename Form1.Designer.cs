namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.배경이미지;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(39, 52, 39, 52);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.6313057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.52996F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.259956F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7893906F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.26313F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.52626F));
            tableLayoutPanel1.Size = new Size(414, 527);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 257F));
            tableLayoutPanel5.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(41, 276);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel5.Size = new Size(332, 27);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Noto Sans KR", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox3.Location = new Point(77, 2);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 31);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans KR", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(2, 1);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 24);
            label3.TabIndex = 0;
            label3.Text = "닉네임";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(41, 341);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50.7042236F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2957764F));
            tableLayoutPanel4.Size = new Size(332, 62);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 254F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(2, 2);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.Size = new Size(328, 27);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans KR", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(2, 1);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 24);
            label2.TabIndex = 0;
            label2.Text = "IP";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Noto Sans KR", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox2.Location = new Point(76, 2);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 31);
            textBox2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 254F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 33);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.Size = new Size(328, 27);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans KR", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(2, 1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 24);
            label1.TabIndex = 0;
            label1.Text = "PORT";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Noto Sans KR", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(76, 2);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 31);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 86);
            pictureBox1.Margin = new Padding(16, 15, 16, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Noto Sans KR", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(41, 429);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(332, 44);
            button1.TabIndex = 2;
            button1.Text = "접속하기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 241);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(414, 527);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TextBox textBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
