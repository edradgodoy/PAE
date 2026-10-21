using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hoteleria
{
    public partial class Form1 : Form
    {
        ConexionBD conexion = new ConexionBD();
        private int idRolSeleccionado = 0;

        public Form1()
        {
            InitializeComponent();
            AplicarEstiloBoton(button1);
            AplicarEstiloBoton(button2);
            AplicarEstiloBoton(button3);
            AplicarEstiloBoton(button4);
            AplicarEstiloBoton(button5);
            CargarRoles();
        }

        private void AplicarEstiloBoton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(0, 84, 139);
            btn.ForeColor = Color.White;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 114, 189);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 109);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }
        // 3. Método CRUD: LEER (Read)
        public void CargarRoles()
        {
            MySqlConnection conn = conexion.AbrirConexion();

            if (conn != null)
            {
                try
                {
                    string query = "SELECT idroles AS ID, name_rol AS Nombre, description_rol AS Descripción FROM roles";

                    // --- ESTAS 5 LÍNEAS FALTABAN ---
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRoles.DataSource = dt;
                    // -------------------------------

                    if (dgvRoles.Columns.Contains("btnEditarGrid")) dgvRoles.Columns.Remove("btnEditarGrid");
                    if (dgvRoles.Columns.Contains("btnEliminarGrid")) dgvRoles.Columns.Remove("btnEliminarGrid");

                    DataGridViewButtonColumn btnEditarGrid = new DataGridViewButtonColumn();
                    btnEditarGrid.Name = "btnEditarGrid";
                    btnEditarGrid.HeaderText = "Editar";
                    btnEditarGrid.Text = "Editar";
                    btnEditarGrid.UseColumnTextForButtonValue = true;
                    dgvRoles.Columns.Add(btnEditarGrid);

                    DataGridViewButtonColumn btnEliminarGrid = new DataGridViewButtonColumn();
                    btnEliminarGrid.Name = "btnEliminarGrid";
                    btnEliminarGrid.HeaderText = "Eliminar";
                    btnEliminarGrid.Text = "Eliminar";
                    btnEliminarGrid.UseColumnTextForButtonValue = true;
                    dgvRoles.Columns.Add(btnEliminarGrid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombreColumna = dgvRoles.Columns[e.ColumnIndex].Name;
                DataGridViewRow fila = dgvRoles.Rows[e.RowIndex];

                if (nombreColumna == "btnEditarGrid")
                {
                    idRolSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
                    txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
                    txtDescripcion.Text = Convert.ToString(fila.Cells["Descripción"].Value);

                    // Ajustado a button6
                    btnRegistrar.Text = "Actualizar";
                }
                else if (nombreColumna == "btnEliminarGrid")
                {
                    int idEliminar = Convert.ToInt32(fila.Cells["ID"].Value);

                    DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar este rol?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        EliminarRol(idEliminar);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            MySqlConnection conn = conexion.AbrirConexion();
            if (conn != null)
            {
                try
                {
                    string query = "";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    if (idRolSeleccionado == 0)
                    {
                        query = "INSERT INTO roles (name_rol, description_rol, created_at, updated_at) VALUES (@nombre, @descripcion, NOW(), NOW())";
                    }
                    else
                    {
                        query = "UPDATE roles SET name_rol = @nombre, description_rol = @descripcion, updated_at = NOW() WHERE idroles = @id";
                        cmd.Parameters.AddWithValue("@id", idRolSeleccionado);
                    }

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(idRolSeleccionado == 0 ? "Rol registrado con éxito." : "Rol actualizado con éxito.");

                    LimpiarFormulario();
                    CargarRoles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        } // <- AQUI ESTABA EL ERROR: Tenías 3 llaves de cierre, ahora solo hay 1.

        private void EliminarRol(int id)
        {
            MySqlConnection conn = conexion.AbrirConexion();
            if (conn != null)
            {
                try
                {
                    string query = "DELETE FROM roles WHERE idroles = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rol eliminado con éxito.");

                    LimpiarFormulario();
                    CargarRoles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            idRolSeleccionado = 0;
            // Ajustado a button6
            btnRegistrar.Text = "Registrar";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}