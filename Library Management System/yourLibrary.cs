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

        private void yourLibrary_Load(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = listView1.SelectedItems[0].SubItems[0].Text;

            MessageBox.Show(selected);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //properties
            listView1.View = View.Details;

            //Construct column
            listView1.Columns.Add("Recommendent", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        //Populate Lv
        private void populate()
        {
            //img list
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            //load img from file
            String[] paths = { };
            paths = Directory.GetFiles("C:\\Libray img\\Your lib\\Recommendation");

            try
            {
                foreach (String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Bind img to listview
            listView1.SmallImageList = imgs;
            listView1.Items.Add("1 The adventure hulkberry -by Mark twain", 0);
            listView1.Items.Add("2 The Jungle -by Upton sinclair", 1);
            listView1.Items.Add("3 Forbidden Knowledge -by Roger Shattuck", 2);
            listView1.Items.Add("4 The hire girl -by Laura amy", 3);
            listView1.Items.Add("5 Pride and Prejudice -by Jane austin", 4);

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            //properties
            listView2.View = View.Details;

            //Construct column
            listView2.Columns.Add("Bookmark", 150);
            listView2.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        //Populate Lv
        private void populat()
        {
            //img list
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            //load img from file
            String[] paths = { };
            paths = Directory.GetFiles("C:\\Libray img\\small");

            try
            {
                foreach (String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Bind img to listview
            listView2.SmallImageList = imgs;
            listView2.Items.Add("1.Onyx Storm -by Rebecca yaros", 0);
            listView2.Items.Add("2.Beautiful ugly -by Alice Feeny", 1);
            listView2.Items.Add("3.The Crash -by Freida Mcfadden", 2);
            listView2.Items.Add("4.The big beautiful life -by Emily Henry", 3);
            listView2.Items.Add("5.Sunrise on the reaping -by Zandro ford", 4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            populat();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = listView2.SelectedItems[0].SubItems[0].Text;

            MessageBox.Show(selected);
        }
    }
}
