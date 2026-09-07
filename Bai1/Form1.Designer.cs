namespace Bai1
{
    partial class SudungLabelvaTextbox
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
            label1 = new Label();
            label2 = new Label();
            txtPassWord = new TextBox();
            lblHienThi = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 89);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 175);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 1;
            label2.Text = "Hiển thị";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(335, 89);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(249, 31);
            txtPassWord.TabIndex = 2;
            txtPassWord.TextChanged += textBox1_TextChanged;
            // 
            // lblHienThi
            // 
            lblHienThi.Location = new Point(335, 169);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(249, 31);
            lblHienThi.TabIndex = 3;
            lblHienThi.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(122, 261);
            button1.Name = "button1";
            button1.Size = new Size(112, 38);
            button1.TabIndex = 4;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(335, 261);
            button2.Name = "button2";
            button2.Size = new Size(112, 38);
            button2.TabIndex = 5;
            button2.Text = "Tiếp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(546, 261);
            button3.Name = "button3";
            button3.Size = new Size(112, 38);
            button3.TabIndex = 6;
            button3.Text = "Đóng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SudungLabelvaTextbox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblHienThi);
            Controls.Add(txtPassWord);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SudungLabelvaTextbox";
            Text = "Sử dụng Label&Textbox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPassWord;
        private TextBox lblHienThi;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
