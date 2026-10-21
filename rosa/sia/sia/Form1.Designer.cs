namespace sia
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
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            inicio = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Fuchsia;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1321, 60);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1196, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(52, 19);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "sistema de prueba";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(inicio);
            panel2.Location = new Point(1, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(1320, 63);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(149, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 60);
            button1.TabIndex = 1;
            button1.Text = "usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inicio
            // 
            inicio.Location = new Point(51, 0);
            inicio.Name = "inicio";
            inicio.Size = new Size(77, 63);
            inicio.TabIndex = 0;
            inicio.Text = "inicio";
            inicio.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(260, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 60);
            button2.TabIndex = 2;
            button2.Text = "categoria";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 889);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button inicio;
        private Button button2;
    }
}
