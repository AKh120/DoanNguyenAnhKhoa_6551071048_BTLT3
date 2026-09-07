namespace Bai3
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
            lblHoTen = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.HotTrack;
            lblHoTen.Location = new Point(0, -2);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(800, 92);
            lblHoTen.TabIndex = 0;
            lblHoTen.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 124);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Họ lót";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 200);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(199, 124);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(398, 31);
            txtHo.TabIndex = 3;
            txtHo.TextChanged += textBox1_TextChanged;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(199, 194);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(398, 31);
            txtTen.TabIndex = 4;
            txtTen.TextChanged += textBox2_TextChanged;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(73, 282);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(112, 34);
            btnHo.TabIndex = 5;
            btnHo.Text = "Họ lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += button1_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(318, 282);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(112, 34);
            btnTen.TabIndex = 6;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += button2_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(566, 282);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(112, 34);
            btnHoTen.TabIndex = 7;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += button3_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(284, 364);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(185, 34);
            btnKetThuc.TabIndex = 8;
            btnKetThuc.Text = "Thoát chương trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Bài Tập Họ và Tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label label2;
        private Label label3;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
    }
}
