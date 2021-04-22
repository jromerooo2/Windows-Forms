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
        static string user = "fernanfloo";
        static string contra = "chorizo";

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            SidePanel.BringToFront();
            login2.BringToFront();
            textUsername.BringToFront();
            textPasswors.BringToFront();
            button4.BringToFront();
            alert.BringToFront();
            alert.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BringToFront();
        }


        private void mySecondCustmControl_Load(object sender, EventArgs e)
        {

        }
        private void firstCustmControl1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl11.BringToFront();
         
        }

        private void button14_Click(object sender, EventArgs e)
        {
            integrantesCustomControl11.BringToFront();
            SidePanel.Hide();
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textPasswors.UseSystemPasswordChar = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPasswors.Text.Trim();

           bool allowed = username.ToLower() == user && password.ToLower() == contra ? true : false ;
            if (allowed)
            {
                firstCustomControl2.BringToFront();
                alert.Hide();
            }
            else
            {
                alert.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void firstCustomControl2_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void integrantesCustomControl11_Load(object sender, EventArgs e)
        {

        }

        private void login2_Load(object sender, EventArgs e)
        {

        }
    }
    }

