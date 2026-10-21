namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificamos si la contraseña está oculta actualmente
            if (textBox2.UseSystemPasswordChar == true)
            {
                // Si está oculta, la mostramos (quitamos la máscara)
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                // Si está visible, la volvemos a ocultar
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {

        }
    }
}
