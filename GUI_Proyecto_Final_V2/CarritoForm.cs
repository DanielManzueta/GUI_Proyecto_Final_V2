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
    public partial class CarritoForm : Form
    {
        public CarritoForm()
        {
            InitializeComponent();
        }

        private void CarritoForm_Load(object sender, EventArgs e)
        {
            label1.Text += "RD$ "+Pedido.getMonto();
            DT1.Columns.Add("Nombre", typeof(string));
            DT1.Columns.Add("Marca", typeof(string));
            DT1.Columns.Add("Precio", typeof(double));
            DT1.Columns.Add("Unidades", typeof(int));
            DT1.Columns.Add("Color", typeof(string));
            for (int i = 0; i < Pedido.getArticulos().Count; i++)
            {
                DT1.Rows.Add(Pedido.getArticulos()[i].getNombre(), Pedido.getArticulos()[i].getMarca(), Pedido.getArticulos()[i].getPrecio(), Pedido.getArticulos()[i].getUnidades(), Pedido.getArticulos()[i].getColor());

            }
            CarritoDataGridView.DataSource = DT1;
        }
        
        private string Concatenante(string x) 
        {
            for(int i=0; i<Pedido.getArticulos().Count; i++)
            {
                x+= "insert into Tabla_Articulo () values ('" + Pedido.getArticulos()[i].getNombre() + "','" + Pedido.getArticulos()[i].getMarca() + "'," + Pedido.getArticulos()[i].getPrecio() + "," + Pedido.getArticulos()[i].getUnidades() + ",'" + Pedido.getArticulos()[i].getColor() + "') where No_Pedido="+Pedido.getNumeroPedido()+"\n\n";

            }
            return x;

           
        }
        

        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-LGNHKNH\\SQLEXPRESS ; database=ProyectoFinal ; integrated security = true");
            conexion.Open();
            string Fecha = Pedido.getFecha();
         
                string cadena = "insert into Tabla_Pedido values ('" + ClassCliente.getUsuario() + "','" + Pedido.getMonto() + "','" + Fecha + "'," + Pedido.getArticulos().Count + ")";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Pedido realizado Excitosamente.");
                conexion.Close();




                conexion.Open();
            string cadena2 = "select No_Pedido from Tabla_Pedido where Fecha='" + Fecha + "';";
            SqlCommand comando2 = new SqlCommand(cadena2, conexion);
            comando2.ExecuteNonQuery();
            SqlDataReader registro = comando2.ExecuteReader();
            try
            {
                
                if (registro.Read())
                {
                    
                    Pedido.setNumeroPedido(int.Parse((registro["No_Pedido"].ToString())));
                    
                }
                
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                registro.Close();
                conexion.Close();
            }

            conexion.Open();
            string x = "";
            string cadena3 = Concatenante(x);
            SqlCommand comando3 = new SqlCommand(cadena3, conexion);
            
            conexion.Close();
            
        }
    }
}
