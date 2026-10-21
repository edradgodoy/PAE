namespace Elementos
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            pcompra = new DataGridViewTextBoxColumn();
            pventa = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(562, 304);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 15, 0, 15);
            button1.Size = new Size(167, 69);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(36, 33);
            button2.TabIndex = 1;
            button2.Text = "N";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(49, 12);
            button3.Name = "button3";
            button3.Size = new Size(36, 33);
            button3.TabIndex = 2;
            button3.Text = "K";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(86, 12);
            button4.Name = "button4";
            button4.Size = new Size(31, 33);
            button4.TabIndex = 3;
            button4.Text = "S";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14F);
            checkBox1.Location = new Point(34, 333);
            checkBox1.Margin = new Padding(5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(316, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Aceptar lo terminos y condiciones";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.ControlDarkDark;
            checkedListBox1.Font = new Font("Segoe UI", 14F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Dirección del cliente", "Logo", "RUC", "Firmas", "Mensaje de factura" });
            checkedListBox1.Location = new Point(12, 62);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(214, 220);
            checkedListBox1.TabIndex = 5;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Limpieza", "Enlatados", "Embutidos", "Lacteos ", "Granos basicos ", "Farmacia ", "Ferreteros", "Tecnologia ", "Plasticos ", "Verduras " });
            comboBox1.Location = new Point(582, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Stock, pcompra, pventa });
            dataGridView1.Location = new Point(232, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(497, 159);
            dataGridView1.TabIndex = 7;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // pcompra
            // 
            pcompra.HeaderText = "P. Compra";
            pcompra.Name = "pcompra";
            // 
            // pventa
            // 
            pventa.HeaderText = "P. Venta";
            pventa.Name = "pventa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 62);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Busqueda";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(376, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(126, 12);
            label1.Name = "label1";
            label1.Size = new Size(224, 30);
            label1.TabIndex = 10;
            label1.Text = "Modulo de productos";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(758, 396);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Code Studio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn pcompra;
        private DataGridViewTextBoxColumn pventa;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}
