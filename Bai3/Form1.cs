namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Nhấn Button btnHo
        private void button1_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        // Nhấn Button btnTen
        private void button2_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        // Nhấn Button btnHoTen
        private void button3_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + "  " + txtTen.Text;
        }

        // Nhấn Button btnKetThuc
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}