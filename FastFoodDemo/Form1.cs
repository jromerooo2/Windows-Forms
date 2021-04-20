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
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
            
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
    }
}
