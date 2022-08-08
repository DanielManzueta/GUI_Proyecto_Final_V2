using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class CalzadoHombre:RopaYCalzado
    {
        //Atributos
        private string Material;
        //Metodos
        public CalzadoHombre()
        {
            this.Material = "Piel";
        }
        public void setMaterial(string Material)
        {
            this.Material = Material;
        }
        public string getMaterial()
        {
            return Material;
        }
    }
}
