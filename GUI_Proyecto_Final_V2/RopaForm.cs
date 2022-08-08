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
    public partial class RopaForm : Form
    {
        public RopaForm()
        {
            InitializeComponent();
        }
        private void RopaForm_Load(object sender, EventArgs e)
        {
            //
            //Cargo Pants
            //
            Cargo_Pants.setNombre("Cargo Pants");
            Cargo_Pants.setMarca("Wrangler");
            Cargo_Pants.setPrecio(1649.45);
            Cargo_Pants.setColor("kaki");
            Cargo_Pants.setTela("Twill");
            Cargo_Pants.setTipoPieza("Cargo Pants");
            //
            //Pantalón de pierna recta elástica
            //
            Cargo_Pants_Elastico.setNombre("Pantalón de pierna recta elástica");
            Cargo_Pants_Elastico.setMarca("Dickies");
            Cargo_Pants_Elastico.setPrecio(2199.45);
            Cargo_Pants_Elastico.setColor("Negro");
            Cargo_Pants.setTela("Algodon");
            Cargo_Pants.setTipoPieza("Cargo Pants");
            //
            //Blusa
            //
            Blusa.setNombre("Blusa");
            Blusa.setMarca("NineDaily");
            Blusa.setPrecio(1429.45);
            Blusa.setColor("Rojo");
            Blusa.setTela("90% Poliester, 10% Elastano");
            Cargo_Pants.setTipoPieza("Blusa Casual");
            //
            //jean Elasticos Ajustados
            //
            jean_Elasticos.setNombre("jean Elasticos Ajustados");
            jean_Elasticos.setMarca("Calvin Klein");
            jean_Elasticos.setPrecio(2199.45);
            jean_Elasticos.setColor("Azul Oscuro");
            jean_Elasticos.setTela("Denim Elastico");
            jean_Elasticos.setTipoPieza("Slim fit Jean");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Cargo_Pants.getNombre() + "\nMarca: "
            + Cargo_Pants.getMarca() +
            "\nPrecio: " + Cargo_Pants.getPrecio().ToString() +
            "\nColor: " + Cargo_Pants.getColor() + "\nTela: " + Cargo_Pants.getTela()
            + "\nTipoPieza: " + Cargo_Pants.getTipoPieza());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Cargo_Pants_Elastico.getNombre()
            + "\nMarca: " + Cargo_Pants_Elastico.getMarca() + "\nPrecio: "
            + Cargo_Pants_Elastico.getPrecio().ToString()
            + "\nColor: " + Cargo_Pants_Elastico.getColor()
            + "\nTela: " + Cargo_Pants.getTela()
            + "\nTipoPieza: " + Cargo_Pants.getTipoPieza());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Blusa.getNombre() + "\nMarca: "
            + Blusa.getMarca() + "\nPrecio: "
            + Blusa.getPrecio().ToString() + "\nColor: " + Blusa.getColor()
            + "\nTela: " + Blusa.getTela()
            + "\nTipoPieza: " + Blusa.getTipoPieza());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + jean_Elasticos.getNombre()
            + "\nMarca: " + jean_Elasticos.getMarca() + "\nPrecio: " + jean_Elasticos.getPrecio().ToString()
            + "\nColor: " + jean_Elasticos.getColor() + "\n:Tela " + jean_Elasticos.getTela()
            + "\nTipoPieza: " + jean_Elasticos.getTipoPieza());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && (comboBox1.Text.Length > 0) && (comboBox2.Text.Length > 0))
            {
                Cargo_Pants.setSize(comboBox1.Text);
                Cargo_Pants.setUnidades(int.Parse(comboBox2.Text));
                ListaRopa.Add(Cargo_Pants);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaRopa.Remove(Cargo_Pants);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && (comboBox4.Text.Length > 0) && (comboBox3.Text.Length > 0))
            {
                Cargo_Pants_Elastico.setSize(comboBox4.Text);
                Cargo_Pants_Elastico.setUnidades(int.Parse(comboBox3.Text));
                ListaRopa.Add(Cargo_Pants_Elastico);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaRopa.Remove(Cargo_Pants_Elastico);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && (comboBox6.Text.Length > 0) && (comboBox5.Text.Length > 0))
            {
                Blusa.setSize(comboBox6.Text);
                Blusa.setUnidades(int.Parse(comboBox5.Text));
                ListaRopa.Add(Blusa);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaRopa.Remove(Blusa);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked && (comboBox11.Text.Length>0) && (comboBox12.Text.Length > 0))
            {
                jean_Elasticos.setSize(comboBox12.Text);
                jean_Elasticos.setUnidades(int.Parse(comboBox11.Text));
                ListaRopa.Add(jean_Elasticos);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaRopa.Remove(jean_Elasticos);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void BotonEnviarCarrito_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListaRopa.Count; i++)
            {
                Pedido.agregarArticulos(ListaRopa[i]);
            }
            MessageBox.Show("Agregados al carrito.");
        }
    }
}
