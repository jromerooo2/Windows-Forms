using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    
    public partial class Form1 : Form
    {
        static string user = "Fernanfloo";
        static string contra = "chorizo";
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();


        }

        private void button14_Click(object sender, EventArgs e)
        {
            integrantesCustomControl1.BringToFront();
            SidePanel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login1_Load(object sender, EventArgs e)
        {
            
        }



        private void mySecondCustmControl3_Load(object sender, EventArgs e)
        {

        }

        private void mySecondCustmControl2_Load(object sender, EventArgs e)
        {

        }

        private void login1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           string usuario = cuserName.Text;
           string password = cpassword.Text;

            if (usuario == user && password == contra)
            {
                mySecondCustmControl1.BringToFront();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpassword_TextChanged(object sender, EventArgs e)
        {
            cpassword.UseSystemPasswordChar = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
