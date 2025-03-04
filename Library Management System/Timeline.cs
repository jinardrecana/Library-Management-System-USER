using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Timeline : Form
    {
        public Timeline()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yourLibrary yourLibrary = new yourLibrary();
            yourLibrary.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trending trending = new Trending();
            trending.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
