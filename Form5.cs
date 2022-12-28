using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFinalProject
{
    public partial class Form5 : Form
    {
        public static double due = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Traditional Bed\t\t25000";
            due = due + 25000;
            dueTbox.Text = due.ToString();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Cabinet Bed\t\t\t28000";
            due = due + 28000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame High Panel Bed\t\t24000";
            due = due + 24000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame BookCase Bed\t\t21000";
            due = due + 21000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Panel Bed\t\t20000";
            due = due + 20000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox17_Click_1(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Traditional Bed\t\t25000";
            due = due + 25000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Cabinet Bed\t\t28000";
            due = due + 28000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Korean Bed\t\t19000";
            due = due + 19000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Modern Bed\t\t25000";
            due = due + 25000;
            dueTbox.Text = due.ToString();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Retro Bed\t\t26000";
            due = due + 26000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Single Bed\t\t20000";
            due = due + 20000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Standard Bed Frame\t25000";
            due = due + 25000;
            dueTbox.Text = due.ToString();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Bookcase Bed \t\t29000";
            due = due + 29000;
            dueTbox.Text = due.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(slipRtbox.Text))
            {
                MessageBox.Show("You can't proceed to check out. Please Select Items.", " Jc Kame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slipRtbox.Clear();
            dueTbox.Clear();
            due = 0; 
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Single");
            comboBox2.Items.Add("Double");
            comboBox2.Items.Add("King");
            comboBox2.Items.Add("Queen");

        }
    }
}
