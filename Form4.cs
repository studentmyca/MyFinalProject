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
    public partial class Form4 : Form
    {
        public static double due = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Alderly Door\t\t12000";
            due = due + 12000;
            duetbox.Text = due.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Burlington  Door\t13000";
            due = due + 13000;
            duetbox.Text = due.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Boston Door\t\t13000";
            due = due + 13000;
            duetbox.Text = due.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Beumont Door\t\t14000";
            due = due + 14000;
            duetbox.Text = due.ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Valencia\t\t13000";
            due = due + 13000;
            duetbox.Text = due.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Newark Door\t\t13000";
            due = due + 13000;
            duetbox.Text = due.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Newport Door\t\t14000";
            due = due + 14000;
            duetbox.Text = due.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame  Newby Door\t\t14000";
            due = due + 14000;
            duetbox.Text = due.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Islington Door\t\t14000";
            due = due + 14000;
            duetbox.Text = due.ToString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            slipRtbox.Text = slipRtbox.Text + "\nJcKame Zurich Door\t\t15000";
            due = due + 15000;
            duetbox.Text = due.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void clearorderbtn_Click(object sender, EventArgs e)
        {
            slipRtbox.Clear();
            duetbox.Clear();
            due = 0;
      
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

        private void slipRtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cbSize.Items.Add("Standard");
            cbSize.Items.Add("Front Door");
            cbSize.Items.Add("Main Door");
            cbSize.Items.Add("Back Door");
        }

        private void cbSize_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
