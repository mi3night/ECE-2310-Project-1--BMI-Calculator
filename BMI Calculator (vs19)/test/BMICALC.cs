using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmicalcvs
{
    public partial class BMICALC : Form
    {
        public BMICALC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double ft, in1, lb;

            if (double.TryParse(textBox1.Text, out ft) &&
                double.TryParse(textBox2.Text, out in1) &&
                double.TryParse(textBox3.Text, out lb) &&
                ft > 0 && in1 >= 0 && in1 <= 12 && lb > 0)
            {

                double bmi = Math.Round(lb / Math.Pow((ft * 12 + in1), 2) * 703, 1);

                Form customMessageBox = new Form();
                customMessageBox.Text = "BMI Calculator Result";
                customMessageBox.Size = new Size(300, 100);
                customMessageBox.StartPosition = FormStartPosition.CenterParent;
                customMessageBox.FormBorderStyle = FormBorderStyle.FixedDialog;



                Label label = new Label();
                label.Text = $"{bmi} is your BMI";
                label.Font = new Font("Comic Sans MS", 12);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;
                customMessageBox.Controls.Add(label);
                customMessageBox.ShowDialog();
            }
            else
            {

                Form customMessageBox = new Form();
                customMessageBox.Text = "BMI Calculator Result";
                customMessageBox.Size = new Size(300, 100);
                customMessageBox.StartPosition = FormStartPosition.CenterParent;
                customMessageBox.FormBorderStyle = FormBorderStyle.FixedDialog;

                Label label = new Label();
                label.Text = $"Invalid Input";
                label.Font = new Font("Comic Sans MS", 12);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;
                customMessageBox.Controls.Add(label);
                customMessageBox.ShowDialog();
            }
        }
    }
}
