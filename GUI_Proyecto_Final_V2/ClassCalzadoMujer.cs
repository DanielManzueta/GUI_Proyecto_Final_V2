using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class CalzadoMujer:RopaYCalzado
    {
        private string TipoCalzado;

        //Constructor

        public CalzadoMujer()
        {
            this.TipoCalzado = "Botines";
        }

        //Metodos
        public void setTipoCalzado(string TipoCalzado)
        {
            this.TipoCalzado = TipoCalzado;

        }

        public string getTipoCalzado()
        {
            return TipoCalzado;

        }
    }
}
