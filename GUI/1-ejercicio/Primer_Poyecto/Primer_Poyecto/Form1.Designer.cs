namespace Primer_Poyecto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(118, 160);
            label1.Name = "label1";
            label1.Size = new Size(657, 45);
            label1.TabIndex = 1;
            label1.Text = "Bienbenido a nuestro sistema de aprendizaje";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(208, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 269);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese sus datos para ingresar al sistema";
            // 
            // button2
            // 
            button2.Location = new Point(345, 101);
            button2.Name = "button2";
            button2.Size = new Size(64, 24);
            button2.TabIndex = 7;
            button2.Text = "Mostrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(24, 143);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 15, 0, 15);
            button1.Size = new Size(385, 70);
            button1.TabIndex = 6;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 102);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ingrese la conrtaseña de su cuenta";
            textBox2.Size = new Size(315, 23);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 84);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 48);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese su nombre o correo de cuenta para ingresar";
            textBox1.Size = new Size(385, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 30);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 602);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
