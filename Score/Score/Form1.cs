namespace Score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        string op = "+";
        TimeSpan sTime = TimeSpan.FromSeconds(0.5);
        DateTime startTime = DateTime.Now;
        DateTime lastSndTime = DateTime.Now;
        private void give_question()
        {
            Random rnd = new Random();
            a = rnd.Next(50) + 1;
            b = rnd.Next(50) + 1;
            switch (rnd.Next(3))
            {
                case 0: op = "+"; break;
                case 1: op = "-"; break;
                case 2: op = "*"; break;
                case 3: op = "/"; break;
                default: op = "+"; break;
            }
            this.label1.Text = a.ToString();
            this.label3.Text = b.ToString();
            this.label2.Text = op.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*give_question();
            DateTime startTime = DateTime.Now;
            DateTime lastSndTime = DateTime.Now;
            this.textBox1.Text = (DateTime.Now - startTime).ToString("g");
            if (DateTime.Now - lastSndTime >= sTime)
            {
                lastSndTime = DateTime.Now;
                this.textBox2.Text = "Update" + (lastSndTime - startTime).ToString("g");
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            give_question();
            
            this.textBox1.Text = (DateTime.Now - startTime).ToString("g");
            if (DateTime.Now - lastSndTime >= sTime)
            {
                lastSndTime = DateTime.Now;
                this.textBox2.Text = "Update" + (lastSndTime - sTime).ToString("g");
            }
        }
    }
}