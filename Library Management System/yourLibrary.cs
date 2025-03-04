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
    public partial class yourLibrary : Form
    {
        public yourLibrary()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Timeline timeline = new Timeline();
            timeline.ShowDialog();
        }
    }
}
