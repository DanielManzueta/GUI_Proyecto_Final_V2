using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class Celular:Electronicos
    {
        private int SIMRanuras;
        private SIM SIMCard;
        private Bateria Bateria;
        private Cargador Cargador;

        public Celular()
        {

            setDimension("171.2 x 77.7 x 8.6 mm");
            setProcesador("Octa-core (4x2.3 GHz Cortex-A53 & 4x1.8 GHz Cortex-A53)");
            setModelo("LG Stylo 6");
            setRAM("3GB");
            setHDD("64GB");
            setGPU("1GB");
            SIMRanuras = 1;
            SIMCard = new SIM();
            Bateria = new Bateria();
            Cargador = new Cargador();

        }

        public void AgregarSIMCard(SIM S)
        {

            SIMCard = S;


        }

        public void AgregarBateria(Bateria B)
        {

            Bateria = B;


        }

        public void AgregarCargador(Cargador C)
        {

            Cargador = C;
        }


        public void setSIMRanuras(int n)
        {

            SIMRanuras = n;

        }

        public int getSIMRanuras()
        {

            return SIMRanuras;
        }

        public void getBateria()
        {

            Console.WriteLine("La bateria del telefono {0} es de {1} Amp y {2} Watts", getModelo(), Bateria.getAmp(), Bateria.getWatts());


        }

        public void getCargador()
        {

            Console.WriteLine("El cargador del telefono {0} es de {1} Voltaje , {2} Watts y de tipo {3}", getModelo(), Cargador.getVolt(), Cargador.getWatts(), Cargador.getTipo());


        }
    }
}
