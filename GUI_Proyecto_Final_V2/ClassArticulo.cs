using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class Articulo
    {

        //Creando variables de instancia.
        private string Nombre;
        private string Marca;
        private double Precio;
        private int Unidades;
        private string Color;

        //Constructor
        public Articulo()
        {
            this.Nombre = "Blusa";
            this.Marca = "Givenchy";
            this.Precio = 4590.98;
            this.Unidades = 4;
            this.Color = "Rojo";
        }

        //Metodos
        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }
        public void setPrecio(double Precio)
        {
            this.Precio = Precio;
        }
        public void setUnidades(int Unidades)
        {
            this.Unidades = Unidades;
        }
        public void setColor(string Color)
        {
            this.Color = Color;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public string getMarca()
        {
            return Marca;
        }
        public double getPrecio()
        {
            return Precio;
        }
        public int getUnidades()
        {
            return Unidades;
        }
        public string getColor()
        {
            return Color;
        }
    }
}
