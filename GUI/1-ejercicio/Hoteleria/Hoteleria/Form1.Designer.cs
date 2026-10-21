namespace Hoteleria
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
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            label4 = new Label();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            dgvRoles = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 50, 82);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1359, 53);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 84, 139);
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(1360, 117);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(1151, 13);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 50, 82);
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(29, 13);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Hotel Sys";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 84, 139);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(1360, 70);
            panel3.TabIndex = 1;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(451, 0);
            button5.Name = "button5";
            button5.Size = new Size(111, 70);
            button5.TabIndex = 4;
            button5.Text = "Habitaciones";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(328, 0);
            button4.Name = "button4";
            button4.Size = new Size(117, 70);
            button4.TabIndex = 3;
            button4.Text = "Roles";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(220, 0);
            button3.Name = "button3";
            button3.Size = new Size(102, 70);
            button3.TabIndex = 2;
            button3.Text = "Categorias";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(139, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 70);
            button2.TabIndex = 1;
            button2.Text = "Usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(58, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 70);
            button1.TabIndex = 0;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(173, 222, 241);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 50, 82);
            groupBox1.Location = new Point(7, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 650);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Roles";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(365, 179);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 33);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 126);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(121, 126);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Decripción del role";
            txtDescripcion.Size = new Size(338, 29);
            txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del puesto";
            txtNombre.Size = new Size(339, 29);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 72);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 0;
            label3.Text = "Nombre";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(11, 157, 251);
            panel4.Location = new Point(2, 788);
            panel4.Name = "panel4";
            panel4.Size = new Size(1359, 62);
            panel4.TabIndex = 3;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(512, 212);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.Size = new Size(836, 549);
            dgvRoles.TabIndex = 4;
            dgvRoles.CellContentClick += dgvRoles_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1359, 845);
            Controls.Add(dgvRoles);
            Controls.Add(panel4);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private GroupBox groupBox1;
        private Panel panel4;
        private Label label4;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label3;
        private Button btnRegistrar;
        private DataGridView dgvRoles;
    }
}
