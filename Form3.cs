using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyFinalProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //We will create GUi
            //buttons that show images
            //files to access images
        }

        string[] pictures = Directory.GetFiles("C:\\designs");

        int pictureindex = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureindex < pictures.Length - 1)
            {
                pictureindex += 1;
                pictureBox1.Image = Image.FromFile(pictures[pictureindex]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureindex > 0)
            {
                pictureindex -= 1;
                pictureBox1.Image = Image.FromFile(pictures[pictureindex]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }
    }
}
