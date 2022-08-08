using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Proyecto_Final_V2
{
    public partial class NuevoUsuarioForm : Form
    {
        private int cont = 0;
        public NuevoUsuarioForm()
        {
            InitializeComponent();
        }
        

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text.Length>0 && ApellidoTextBox.Text.Length>0 && CorreoTextBox.Text.Length>0 && PasswordTextBox.Text.Length>0 && PasswordVerifyTextBox.Text.Length>0 && CorreosComboBox.Text.Length>0 && UsuarioTextBox.Text.Length>0)
            {
                if (PasswordTextBox.Text==PasswordVerifyTextBox.Text)
                {
                    SqlConnection conexion = new SqlConnection("server=DESKTOP-LGNHKNH\\SQLEXPRESS ; database=ProyectoFinal ; integrated security = true");
                    conexion.Open();
                    string cadena = "insert into Tabla_Cliente values ('" + UsuarioTextBox.Text + "','" + NombreTextBox.Text + "','" + ApellidoTextBox.Text + "','" + CorreoTextBox.Text+CorreosComboBox.Text + "','" + PasswordTextBox.Text + "')";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente");
                    UsuarioTextBox.Text = "";
                    NombreTextBox.Text = "";
                    ApellidoTextBox.Text = "";
                    CorreoTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    PasswordVerifyTextBox.Text = "";
                    conexion.Close();
                    inicioSecionForm1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ambas contraseña deben coincidir.");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new UsuarioForm().Show();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                PasswordTextBox.PasswordChar = '\0';
                pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\Daniel\\Desktop\\Tareas\\Semestre 2022-15(Verano)\\ProyectoFinalGUI\\ProyectoFinalGUI\\Imagenes\\hide.png");
                cont = 1;
            }
            else if (cont == 1)
            {
                PasswordTextBox.PasswordChar = '*';
                pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\Daniel\\Desktop\\Tareas\\Semestre 2022-15(Verano)\\ProyectoFinalGUI\\ProyectoFinalGUI\\Imagenes\\show.png");
                cont = 0;
            }
        }
    }
}
