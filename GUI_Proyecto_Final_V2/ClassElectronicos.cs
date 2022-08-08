using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class Electronicos:Articulo
    {
        //Atributos
        private string Dimension;
        private string Procesador;
        private string Modelo;
        private string RAM;
        private string HDD;
        private string GPU;
        //Metodos
        public Electronicos()
        {
            this.Dimension = "";
            this.Procesador = "";
            this.Modelo = "";
            this.RAM = "4 GB";
            this.HDD = "16 GB";
            this.GPU = "8 GB";
        }
        public void setDimension(string Dimension)
        {
            this.Dimension = Dimension;
        }
        public void setProcesador(string Procesador)
        {
            this.Procesador = Procesador;
        }
        public void setModelo(string Modelo)
        {
            this.Modelo = Modelo;
        }
        public void setRAM(string RAM)
        {
            this.RAM = RAM;
        }
        public void setHDD(string HDD)
        {
            this.HDD = HDD;
        }
        public void setGPU(string GPU)
        {
            this.GPU = GPU;
        }
        public string getDimension() { return Dimension; }
        public string getProcesador() { return Procesador; }
        public string getModelo() { return Modelo; }
        public string getRAM() { return RAM; }
        public string getHDD() { return HDD; }
        public string getGPU() { return GPU; }
    }
}
