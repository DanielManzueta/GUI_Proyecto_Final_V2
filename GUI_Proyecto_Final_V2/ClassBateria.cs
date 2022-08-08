using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class Bateria
    {
        private double Amp;
        private double Watts;

        public Bateria()
        {

            Amp = 100;
            Watts = 100;

        }
        public Bateria(int a, int b)
        {

            Amp = a;
            Watts = b;

        }


        public void setAmp(double x)
        {
            Amp = x;

        }

        public void setWatts(double s)
        {

            Watts = s;


        }

        public double getAmp()
        {

            return Amp;

        }
        public double getWatts()
        {
            return Watts;

        }
    }
}
