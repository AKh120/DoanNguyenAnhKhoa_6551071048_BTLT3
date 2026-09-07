namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // sự kiện khi Button được click
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        // sự kiện khi load form
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }

        // sự kiện khi form được Click
        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }
    }
}
