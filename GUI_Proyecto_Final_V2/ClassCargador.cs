using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class Cargador
    {
        private double Volt;
        private double Watts;
        private string Tipo;

        public Cargador()
        {
            Volt = 5;
            Watts = 100;
            Tipo = "tipo c";
        }

        public Cargador(int c, int r, string k)
        {
            Volt = c;
            Watts = r;
            Tipo = k;
        }

        public void setVolt(double m)
        {
            Volt = m;
        }

        public void setWatts(double a)
        {
            Watts = a;
        }

        public void setTipo(string p)
        {
            Tipo = p;
        }

        public double getVolt()
        {
            return Volt;
        }

        public double getWatts()
        {
            return Watts;
        }

        public string getTipo()
        {
            return Tipo;
        }
    }
}
