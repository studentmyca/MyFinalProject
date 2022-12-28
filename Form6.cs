using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinalProject
{
    public partial class Form6 : Form
    {
        public static double due = 0;   
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Slide-In\t\t35000";
            due = due + 35000;
            Duetbox.Text = due.ToString();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Premium Crafted\t35000";
            due = due + 35000;
            Duetbox.Text = due.ToString();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Modern\t\t35000";
            due = due + 35000;
            Duetbox.Text = due.ToString();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Modern\t\t35000";
            due = due + 35000;
            Duetbox.Text = due.ToString();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Luxury\t\t35000";
            due = due + 35000;
            Duetbox.Text = due.ToString();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Dinner Set\t\t35000";
            due = due + 35000;
            Duetbox.Text = due.ToString();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Dinner Set\t\t35000";
            due = due + 35000;
            Duetbox.Text = due.ToString();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Square Chair\t40000";
            due = due + 40000;
            Duetbox.Text = due.ToString();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Square Chair\t40000";
            due = due + 40000;
            Duetbox.Text = due.ToString();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Elegant\t\t45000";
            due = due + 45000;
            Duetbox.Text = due.ToString();

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
            Duetbox.Clear();
            due = 0; 
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("12");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
} 
