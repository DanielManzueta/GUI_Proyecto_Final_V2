using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class Ropa:RopaYCalzado
    {
        private string Tela;
        private string TipoPieza;

        public Ropa()
        {
            Tela = "Seda";
            TipoPieza = "Pantalon";
        }

        public void setTela(string tela)
        {
            Tela = tela;
        }

        public string getTela()
        {
            return Tela;
        }

        public void setTipoPieza(string Tipopieza)
        {
            TipoPieza = Tipopieza;
        }

        public string getTipoPieza()
        {
            return TipoPieza;
        }
    }
}
