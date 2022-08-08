using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class RopaYCalzado:Articulo
    {
        //atributes
        private string Size;

        //Constructor
        public RopaYCalzado()
        {
            this.Size = "L";
        }
        //metodo
        public void setSize(string Size)
        {
            this.Size = Size;
        }
        public string getSize()
        {
            return Size;
        }
    }
}
