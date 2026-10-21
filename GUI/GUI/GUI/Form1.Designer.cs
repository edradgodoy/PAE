namespace GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            botonRedondeado1 = new BotonRedondeado();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(100, 142);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 10, 15, 10);
            label1.Size = new Size(455, 65);
            label1.TabIndex = 0;
            label1.Text = "Bienbenidos al proyecto PAE";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(botonRedondeado1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(109, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 322);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese sus datos para ingresar al sistema";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(420, 105);
            button2.Name = "button2";
            button2.Size = new Size(35, 26);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.MediumSlateBlue;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(13, 229);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(444, 51);
            botonRedondeado1.TabIndex = 4;
            botonRedondeado1.Text = "Recuperar cuenta";
            botonRedondeado1.UseVisualStyleBackColor = false;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(13, 173);
            button1.Name = "button1";
            button1.Size = new Size(444, 49);
            button1.TabIndex = 3;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 102);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ingrese la contraseña de su cuenta";
            textBox2.Size = new Size(309, 29);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 105);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 1;
            label3.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 39);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese su nombre de usuario ";
            textBox1.Size = new Size(342, 29);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 42);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(688, 635);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Inicio de Sesión";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private BotonRedondeado botonRedondeado1;
        private Button button2;
    }
}
