using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class Consola : Electronicos
    {
        private string Generacion;
        private Bateria Bateria;
        private Cargador Cargador = null;

        public Consola()
        {

            setDimension("171.2 x 77.7 x 8.6 cm");
            setProcesador("Octa-core (4x2.3 GHz Cortex-A53 & 4x1.8 GHz Cortex-A53)");
            setModelo("Play Station");
            Generacion = "4";
            setRAM("3GB");
            setHDD("64GB");
            setGPU("1GB");

            Bateria = new Bateria();


        }



        public void AgregarBateria(Bateria B)
        {

            Bateria = B;


        }

        public void AgregarCargador(Cargador C)
        {

            Cargador = C;
        }


        public void SetGeneracion(string n)
        {

            Generacion = n;

        }

        public string getSIMRanuras()
        {

            return Generacion;
        }

        public void getBateria()
        {

            Console.WriteLine("La bateria de la consola {0} {1} es de {2} Amp y {3} Watts", getModelo(), Generacion, Bateria.getAmp(), Bateria.getWatts());

        }

        public void getCargador()
        {
            Console.WriteLine("El cargador de la consola {0} {1} es de {2} Voltaje , {3} Watts y de tipo {4}", getModelo(), Generacion, Cargador.getVolt(), Cargador.getWatts(), Cargador.getTipo());

        }
    }
}
