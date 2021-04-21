namespace FastFoodDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userName = new System.Windows.Forms.TextBox();
            this.cpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FondoInicio = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPasswors = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.login2 = new FastFoodDemo.Login();
            this.mySecondCustmControl11 = new FastFoodDemo.MySecondCustmControl1();
            this.integrantesCustomControl11 = new FastFoodDemo.integrantesCustomControl1();
            this.firstCustomControl2 = new FastFoodDemo.FirstCustomControl();
            this.alert = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 718);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 91);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Blue;
            this.SidePanel.Location = new System.Drawing.Point(1, 75);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 66);
            this.SidePanel.TabIndex = 4;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(4, 672);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(48, 42);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lo mas vendido";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(16, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 66);
            this.button2.TabIndex = 4;
            this.button2.Text = "Menu principal";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(1187, 23);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(43, 43);
            this.button11.TabIndex = 4;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(1237, 23);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 43);
            this.button12.TabIndex = 4;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(1288, 23);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(43, 43);
            this.button13.TabIndex = 4;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(805, 487);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 74);
            this.button3.TabIndex = 9;
            this.button3.Text = "Iniciar Sesion";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(740, 280);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(276, 22);
            this.userName.TabIndex = 10;
            this.userName.Tag = "Ingrese su nombre de usuario";
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // cpassword
            // 
            this.cpassword.BackColor = System.Drawing.Color.White;
            this.cpassword.Location = new System.Drawing.Point(740, 396);
            this.cpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpassword.Name = "cpassword";
            this.cpassword.Size = new System.Drawing.Size(276, 22);
            this.cpassword.TabIndex = 11;
            this.cpassword.TextChanged += new System.EventHandler(this.cpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(787, 334);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(27, 6, 27, 6);
            this.label4.Size = new System.Drawing.Size(198, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = "CONTRASEÑA:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(800, 220);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(27, 6, 27, 6);
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "USUARIO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FondoInicio
            // 
            this.FondoInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.FondoInicio.Image = ((System.Drawing.Image)(resources.GetObject("FondoInicio.Image")));
            this.FondoInicio.Location = new System.Drawing.Point(297, 0);
            this.FondoInicio.Margin = new System.Windows.Forms.Padding(4);
            this.FondoInicio.Name = "FondoInicio";
            this.FondoInicio.Size = new System.Drawing.Size(1060, 745);
            this.FondoInicio.TabIndex = 15;
            this.FondoInicio.TabStop = false;
            this.FondoInicio.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.LightCoral;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(797, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Otaku";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(817, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Restaurante";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(616, 335);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(192, 22);
            this.textUsername.TabIndex = 19;
            this.textUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textPasswors
            // 
            this.textPasswors.Location = new System.Drawing.Point(616, 396);
            this.textPasswors.Name = "textPasswors";
            this.textPasswors.Size = new System.Drawing.Size(192, 22);
            this.textPasswors.TabIndex = 20;
            this.textPasswors.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(626, 470);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Iniciar Sesion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // login2
            // 
            this.login2.Location = new System.Drawing.Point(287, 0);
            this.login2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login2.Name = "login2";
            this.login2.Size = new System.Drawing.Size(857, 620);
            this.login2.TabIndex = 18;
            // 
            // mySecondCustmControl11
            // 
            this.mySecondCustmControl11.Location = new System.Drawing.Point(287, 0);
            this.mySecondCustmControl11.Margin = new System.Windows.Forms.Padding(4);
            this.mySecondCustmControl11.Name = "mySecondCustmControl11";
            this.mySecondCustmControl11.Size = new System.Drawing.Size(1089, 610);
            this.mySecondCustmControl11.TabIndex = 17;
            // 
            // integrantesCustomControl11
            // 
            this.integrantesCustomControl11.Location = new System.Drawing.Point(287, 0);
            this.integrantesCustomControl11.Name = "integrantesCustomControl11";
            this.integrantesCustomControl11.Size = new System.Drawing.Size(886, 591);
            this.integrantesCustomControl11.TabIndex = 16;
            // 
            // firstCustomControl2
            // 
            this.firstCustomControl2.Location = new System.Drawing.Point(287, 0);
            this.firstCustomControl2.Margin = new System.Windows.Forms.Padding(4);
            this.firstCustomControl2.Name = "firstCustomControl2";
            this.firstCustomControl2.Size = new System.Drawing.Size(1089, 718);
            this.firstCustomControl2.TabIndex = 10;
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.alert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alert.Location = new System.Drawing.Point(593, 544);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(233, 17);
            this.alert.TabIndex = 22;
            this.alert.Text = "Tu usuario o contra son incorrectos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 718);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textPasswors);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.login2);
            this.Controls.Add(this.mySecondCustmControl11);
            this.Controls.Add(this.integrantesCustomControl11);
            this.Controls.Add(this.firstCustomControl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.FondoInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondoInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox cpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox FondoInicio;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FirstCustomControl firstCustomControl2;
        private integrantesCustomControl1 integrantesCustomControl11;
        private MySecondCustmControl1 mySecondCustmControl11;
        private Login login2;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPasswors;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label alert;
    }
}

