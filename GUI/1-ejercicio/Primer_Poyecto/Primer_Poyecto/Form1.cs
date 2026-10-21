namespace Primer_Poyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificamos si la contraseña está oculta actualmente
            if (textBox2.UseSystemPasswordChar == true)
            {
                // Si está oculta, la mostramos (quitamos la máscara)
                textBox2.UseSystemPasswordChar = false;
                button2.Text = "Ocultar";
                button1.Enabled = false;
                button1.BackColor = "DimGray";

            }
            else
            {
                // Si está visible, la volvemos a ocultar
                textBox2.UseSystemPasswordChar = true;
                button2.Text = "Mostrar";
                button1.Enabled = true;
                button1.BackColor = "DogerBlue";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
