namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.textBox1.Text;
            this.label1.Font = new Font("Arial", 15, FontStyle.Bold);
            this.label1.BackColor = Color.FromArgb(222, 233, 100);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.textBox1.Text;
        }
    }
}