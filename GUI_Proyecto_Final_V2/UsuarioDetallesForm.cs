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
    public partial class UsuarioDetallesForm : Form
    {
        public UsuarioDetallesForm()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-LGNHKNH\\SQLEXPRESS ; database=ProyectoFinal ; integrated security = true");
        private void UsuarioDetallesForm_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text += " " + ClassCliente.getUsuario();
            NombreLabel.Text += " " + ClassCliente.getNombre();
            ApellidoLabel.Text += " " + ClassCliente.getApellido();
            CorreoLabel.Text +=" "+ClassCliente.getCorreo();
            ContraseñaLabel.Text += " " + ClassCliente.getContraseña();
            try
            {
                string Query = "select No_Pedido,Fecha,Cantidad,Monto from Tabla_Pedido where Usuario='"+ClassCliente.getUsuario()+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("No data.");
            }
        }
    }
}
