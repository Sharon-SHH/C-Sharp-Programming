namespace protectScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int stepX = 10;
        int stepY = 12;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Left += stepX;
            this.label1.Top += stepY;
            if (this.label1.Left + this.label1.Width > this.Width || this.label1.Left < 0) // this is not this.Right
             {
                 //this.label1.Left = this.Right;
                 stepX = -stepX;
             }
             if (this.label1.Top + this.label1.Height > this.Height || this.label1.Top < 0)
             {
                 //this.label1.Top = this.Bottom;
                 stepY = -stepY;
             }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}