using global::System;
using global::System.Collections.Generic;
using global::System.Drawing;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;


using global::System.Windows.Forms;





using bmicalcvs;


namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
                Form1 f = new Form1();
                f.TopLevel = false;
                mainpanel.Controls.Add(f);
                f.BringToFront();
                f.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMICALC f = new BMICALC();
            f.TopLevel = false;
            mainpanel.Controls.Add(f);
            f.BringToFront();
            f.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainmenuForm f = new mainmenuForm();
            f.TopLevel = false;
            mainpanel.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            helpForm f = new helpForm();
            f.TopLevel = false;
            mainpanel.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            creditForm f = new creditForm();
            f.TopLevel = false;
            mainpanel.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}