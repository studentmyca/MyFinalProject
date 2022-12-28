using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinalProject
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (string .IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please put your name first before submitting", "Jc Kame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult iOK;
                iOK = MessageBox.Show("Your Order is now in process.You can message us for more Information about your Order! We will contact you for Delivery! Thank You! .", "JcKame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iOK == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
