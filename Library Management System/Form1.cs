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

        private void Form1_Load(object sender, EventArgs e)
        {
            //properties
            listView1.View = View.Details;

            //Construct column
            listView1.Columns.Add("Trending Books", 150);
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
            listView1.SmallImageList = imgs;
            listView1.Items.Add("1 -by Rebecca Yarros", 0);
            listView1.Items.Add("2 -by Alice Feeney", 1);
            listView1.Items.Add("3 -by Freida McFadden", 2);
            listView1.Items.Add("4 -by Emily Henry", 3);
            listView1.Items.Add("5 -by Suzanne Collins", 4);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = listView1.SelectedItems[0].SubItems[0].Text;

            MessageBox.Show(selected);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

        }
    }
}