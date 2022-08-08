using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class Laptop:Electronicos
    {
        private string Tipo;
        private Bateria Bateria;
        private Cargador Cargador = null;

        public Laptop()
        {

            setDimension("90.2 x 30.7 x 2.3 cm");
            setProcesador("Intel I7 8va Generación");
            setModelo("Dell Latitude 7220");
            setRAM("8 GB");
            setHDD("512 GB");
            setGPU("2 GB");
            Tipo = "Laptop de Oficina";
            Bateria = new Bateria();



        }

        public Laptop(Bateria Battery)
        {

            setDimension("90.2 x 30.7 x 2.3 cm");
            setProcesador("Intel I7 8va Generación");
            setModelo("Dell Latitude 7220");
            setRAM("8 GB");
            setHDD("512 GB");
            setGPU("4GB");
            Tipo = "Laptop de Oficina";
            Bateria = Battery;



        }

        public void AgregarCargador(Cargador C)
        {

            Cargador = C;
        }


        public void setTipo(string S)
        {

            Tipo = S;

        }

        public string getTipo()
        {

            return Tipo;

        }

        public void getBateria()
        {

            Console.WriteLine("La bateria de la Laptop {0} es de {1} Amp y {2} Watts", getModelo(), Bateria.getAmp(), Bateria.getWatts());


        }

        public void getCargador()
        {
            Console.WriteLine("El cargador de la Laptop {0} es de {1} Voltaje , {2} Watts y de tipo {3}", getModelo(), Cargador.getVolt(), Cargador.getWatts(), Cargador.getTipo());


        }
    }
}
