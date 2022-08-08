using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal class SIM
    {
        private string Company;
        private string Size;


        public SIM()
        {

            Company = "Claro";
            Size = "Micro chip";

        }

        public SIM(string h, string n)
        {

            Company = h;
            Size = n;

        }
        public void SetCompany(string d)
        {
            Company = d;

        }

        public void SetSize(string size)
        {
            Size = size;

        }

        public string getCompany()
        {
            return Company;
        }

        public string getSize()
        {
            return Size;
        }
    }
}
