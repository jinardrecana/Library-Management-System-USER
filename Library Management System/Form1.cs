namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            yourLibrary frm1 = new yourLibrary();
            frm1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Trending trending = new Trending();
            trending.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Timeline timeline = new Timeline();
            timeline.ShowDialog();
        }
    }
}
