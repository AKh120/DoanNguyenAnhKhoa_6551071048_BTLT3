namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            radioButton1.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Nhập TextBox trên thì hiển thị ở TextBox dưới
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        // Red
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.ForeColor = Color.Red;
            }
        }

        // Green
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.ForeColor = Color.Green;
            }
        }

        // Blue
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox2.ForeColor = Color.Blue;
            }
        }

        // Black
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox2.ForeColor = Color.Black;
            }
        }

        // Chữ đậm
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Font = new Font(
                textBox2.Font.Name,
                textBox2.Font.Size,
                textBox2.Font.Style ^ FontStyle.Bold);
        }

        // Chữ nghiêng
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Font = new Font(
                textBox2.Font.Name,
                textBox2.Font.Size,
                textBox2.Font.Style ^ FontStyle.Italic);
        }

        // Gạch chân
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Font = new Font(
                textBox2.Font.Name,
                textBox2.Font.Size,
                textBox2.Font.Style ^ FontStyle.Underline);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Nút thoát
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}