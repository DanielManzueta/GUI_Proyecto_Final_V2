using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Proyecto_Final_V2
{
    public partial class DetallesArticulosForm : Form
    {
        public DetallesArticulosForm()
        {
            InitializeComponent();
        }
        public static string getTextBox1()
        {
            return textBox1.Text;
        }
        public static void setTextBox(string st)
        {
            try
            {
                DetallesArticulosForm.textBox1.Text = st;
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
