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
    public partial class InicioSecionForm : Form
    {
        private int cont = 0;
        public InicioSecionForm()
        {
            InitializeComponent();
        }

        private void AccederBoton_Click(object sender, EventArgs e)
        {
            
            if (UsuarioTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0)
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-LGNHKNH\\SQLEXPRESS ; database=ProyectoFinal ; integrated security = true");
                conexion.Open();
                try 
                {
                    string cadena = "select * from Tabla_Cliente where Usuario='" + UsuarioTextBox.Text+"'";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    SqlDataReader registro = comando.ExecuteReader();
                    if (registro.Read())
                    {
                        if (registro["Usuario"].ToString()== UsuarioTextBox.Text)
                        {
                            if (registro["Contraseña"].ToString() == PasswordFiller(PasswordTextBox.Text))
                            {
                                ClassCliente.setUsuario(registro["Usuario"].ToString());
                                ClassCliente.setNombre(registro["Nombre"].ToString());
                                ClassCliente.setApellido(registro["Apellido"].ToString());
                                ClassCliente.setCorreo(registro["E_mail"].ToString());
                                ClassCliente.setContraseña(registro["Contraseña"].ToString());
                                menuPrincipal.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Contraseña Incorrecta.");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este usuario no existe.");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Valores ingresados no existen.");
                }
                finally
                {
                    conexion.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.");
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
        public string PasswordFiller(string Password)
        {
            if (Password.Length == 12)
            {
                return Password;
            }
            else
            {
                int diferencia = 12 - Password.Length;
                string newPassword;
                for (int i = 0; i < diferencia; i++)
                {
                    Password += " ";
                }
                newPassword = Password;
                return newPassword;
            }
        }
    }
}
