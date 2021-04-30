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
        //Inicializando credenciales globales
        static string[] user = { "Fernanfloo", "JosueGuinea", "JhansiAguilar"};
        static string[] contra = { "chorizo", "auronplay", "rubius" };
 
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            SidePanel.BringToFront();
            login2.BringToFront();
            textUsername.BringToFront();
            textPasswors.BringToFront();
            btnIniciaSesion.BringToFront();
            alert.BringToFront();
            alert.Hide();
            Alert3.Hide();

        }
        //Inicializando texto censurado para label Password
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textPasswors.UseSystemPasswordChar = true;
        }
        //checkeando si estan vacios los inputs
        private bool CheckIfEmpty(string username, string password)
        {
            bool userRes = String.IsNullOrEmpty(username);
            bool passwordRes = String.IsNullOrEmpty(password);
            if (userRes && passwordRes)
            {
                return true;
            }
            else
            {
                return false;
               
            }
        }
        //Funcionalidad Login
        static bool allowed = false;
        private void Login(string username, string password)
        {         
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i].Contains(username) && contra[i].Contains(password))
                {
                    alert.Hide();
                    Alert3.Hide();
                    alert2.Hide();

                    allowed = true;
                    firstCustomControl2.BringToFront();
                }
                else
                {

                    alert.BringToFront();
                    alert.Show();
                }

            }
            
        }
        //Evento de click al boton de inicio de sesion


        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
             string username = textUsername.Text.Trim();
             string password = textPasswors.Text.Trim();

            bool emptyTextBoxes = CheckIfEmpty(username, password);

            if (emptyTextBoxes)
            {

                alert.Hide();
                Alert3.Hide();
                alert2.BringToFront();
                alert2.Show();
            }
            else
            {
                alert.Hide();
                alert2.Hide();
                Alert3.Hide();

                Login(username, password);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BringToFront();
        }
        //Checkeando si se puede traer al frente los demas componentes
        private void button1_Click(object sender, EventArgs e)
        {

            if (!allowed)
            {
                alert.Hide();
                alert2.Hide();
                Alert3.BringToFront();
                Alert3.Show();
            }
            else
            {
                alert.Hide();
                alert2.Hide();
                Alert3.Hide();
                SidePanel.Show();
                SidePanel.Height = button1.Height;
                SidePanel.Top = button1.Top;
                firstCustomControl2.BringToFront();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!allowed)
            {
                alert.Hide();
                alert2.Hide();
                Alert3.BringToFront();
                Alert3.Show();
            }
            else
            {
                alert.Hide();
                alert2.Hide();
                Alert3.Hide();
                SidePanel.Show();
                SidePanel.Height = button2.Height;
                SidePanel.Top = button2.Top;
                mySecondCustmControl11.BringToFront();
            }


        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (!allowed)
            {
                alert.Hide();
                alert2.Hide();
                Alert3.BringToFront();
                Alert3.Show();
            }
            else
            {
                alert.Hide();
                alert2.Hide();
                Alert3.Hide();
                integrantesCustomControl11.BringToFront();
                SidePanel.Hide();
            }
        }


        private void mySecondCustmControl_Load(object sender, EventArgs e)
        {

        }
        private void firstCustmControl1_Load(object sender, EventArgs e)
        {

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

