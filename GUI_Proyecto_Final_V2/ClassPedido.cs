using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GUI_Proyecto_Final_V2
{
    internal class Pedido
    {
        //Atributos
        private static int NumeroPedido;
        //private Cliente Comprador;
        private static List<Articulo> articulos=new List<Articulo>();
        private static double Monto;
        private double Descuento;
        private static DateTime Fecha = DateTime.Now;
        private double Precio;
        //Metodos
        public Pedido() { }
        public static void setNumeroPedido(int numeroPedido)
        {
            NumeroPedido = numeroPedido;
        }
        //public setComprador(Cliente);
        public static void setArticulos(List<Articulo> X)
        {
            for(int i = 0; i < X.Count; i++)
            {
                articulos.Add(X[i]);
            }
        }
        public static void agregarArticulos(Articulo x)
        {
            articulos.Add(x);
        }
        public static List<Articulo> getArticulos()
        {
            return articulos;
        }
        private static void  setMonto()
        {
            double x = 0;
            for(int i=0; i < articulos.Count; i++)
            {
                x = x + (articulos[i].getPrecio() * articulos[i].getUnidades());
            }
            Monto = x;
        }
        public void setDescuento(double Descuento)
        {
            this.Descuento = Descuento;
        }
        
        public void setPrecio(double Precio)
        {
            this.Precio = Precio;
        }
        public static int getNumeroPedido() { return NumeroPedido; }
        //public Cliente getComprador();
        //public List<Articulo> getArticulos();
        public static double getMonto() 
        {
            setMonto();
            return Monto;
        }
        public double getDescuento() { return Descuento; }
        public static string getFecha() { return Fecha.ToString("MM/dd/yyyy HH:mm:ss"); }
        public double getPrecio() { return Precio; }
        
    }
}
