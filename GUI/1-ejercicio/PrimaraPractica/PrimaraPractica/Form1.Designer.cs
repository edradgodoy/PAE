namespace PrimaraPractica
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 24);
            label1.TabIndex = 0;
            label1.Text = "Hotel Transilvania";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1314, 104);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros de busqueda";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Seleccione un estado", "Ocupada", "Reservado", "Limpieza", "Mantenimiento" });
            comboBox1.Location = new Point(711, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(584, 32);
            comboBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 39);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Capacidad de huespedes";
            textBox2.Size = new Size(324, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 39);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Criterio de busqueda";
            textBox1.Size = new Size(324, 30);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(66, 243);
            button1.Name = "button1";
            button1.Size = new Size(513, 48);
            button1.TabIndex = 2;
            button1.Text = "Agregar Habitacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(66, 330);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1279, 260);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Habitacion";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 23);
            textBox3.TabIndex = 1;
            textBox3.Text = "Nombre de la Habitacion";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre de habitacion";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = " Numero de Habitacion";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(380, 48);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 23);
            textBox5.TabIndex = 5;
            textBox5.Text = "Precio";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(591, 48);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(146, 23);
            textBox6.TabIndex = 6;
            textBox6.Text = "Capacidad";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(770, 48);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(151, 23);
            textBox7.TabIndex = 7;
            textBox7.Text = "Aire acondicionador";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(966, 48);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 8;
            textBox8.Text = "Baño privado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 927);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hotel Transilvania";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
