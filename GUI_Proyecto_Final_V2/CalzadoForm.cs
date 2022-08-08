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
    public partial class CalzadoForm : Form
    {
        public CalzadoForm()
        {
            InitializeComponent();
        }

        private void CalzadoForm_Load(object sender, EventArgs e)
        {
            //
            //Nike Air Zoom Pegasus 39
            //
            Nike_Air_Zoom.setNombre("Nike Air Zoom Pegasus 39");
            Nike_Air_Zoom.setMarca("Nike");
            Nike_Air_Zoom.setPrecio(7150);
            Nike_Air_Zoom.setColor("Gris y verde");
            //
            //Bruno Marc Mocasines
            //
            Mocasines.setNombre("Mocasines de vestir");
            Mocasines.setMarca("Bruno Marc");
            Mocasines.setPrecio(2450);
            Mocasines.setColor("Negro");
            Mocasines.setMaterial("Piel Sintetica");
            //
            //Zapatos de Tacon
            //
            Zapatos_de_Tacon.setNombre("Zapatos de Tacon Michelle");
            Zapatos_de_Tacon.setMarca("Naturalizer");
            Zapatos_de_Tacon.setPrecio(3024.45);
            Zapatos_de_Tacon.setColor("Rosa");
            Zapatos_de_Tacon.setTipoCalzado("Zapatilla");
            //
            //tenis de Lona
            //
            Tenis_Lona.setNombre("Tenis de lona para mujer, con cordones, estilo clásico vintage");
            Tenis_Lona.setMarca("TRETORN Nyliteplus");
            Tenis_Lona.setPrecio(3245);
            Tenis_Lona.setColor("Rosa y Blanco");
            Tenis_Lona.setTipoCalzado("Zapatos Semicasual");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Nike_Air_Zoom.getNombre() + "\nMarca: " + Nike_Air_Zoom.getMarca()
            + "\nPrecio: " + Nike_Air_Zoom.getPrecio().ToString() + "\nColor: " + Nike_Air_Zoom.getColor());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Mocasines.getNombre() + "\nMarca: "
            + Mocasines.getMarca() + "\nPrecio: " + Mocasines.getPrecio().ToString()
            + "\nColor: " + Mocasines.getColor() + "\n: Material " + Mocasines.getMaterial());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Zapatos_de_Tacon.getNombre()
            + "\nMarca: " + Zapatos_de_Tacon.getMarca() + "\nPrecio: " + Zapatos_de_Tacon.getPrecio().ToString()
            + "\nColor: " + Zapatos_de_Tacon.getColor() + "\n: TipoCalzado " + Zapatos_de_Tacon.getTipoCalzado());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Tenis_Lona.getNombre() + "\nMarca: " + Tenis_Lona.getMarca()
            + "\nPrecio: " + Tenis_Lona.getPrecio().ToString()
            + "\nColor: " + Tenis_Lona.getColor() + "\n: TipoCalzado " + Tenis_Lona.getTipoCalzado());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && (comboBox1.Text.Length > 0) && (comboBox2.Text.Length > 0))
            {
                Nike_Air_Zoom.setSize(comboBox1.Text);
                Nike_Air_Zoom.setUnidades(int.Parse(comboBox2.Text));
                ListaCalzados.Add(Nike_Air_Zoom);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaCalzados.Remove(Nike_Air_Zoom);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && (comboBox4.Text.Length > 0) && (comboBox3.Text.Length > 0))
            {
                Mocasines.setSize(comboBox4.Text);
                Mocasines.setUnidades(int.Parse(comboBox3.Text));
                ListaCalzados.Add(Mocasines);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaCalzados.Remove(Mocasines);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && (comboBox6.Text.Length > 0) && (comboBox5.Text.Length > 0))
            {
                Zapatos_de_Tacon.setSize(comboBox6.Text);
                Zapatos_de_Tacon.setUnidades(int.Parse(comboBox5.Text));
                ListaCalzados.Add(Zapatos_de_Tacon);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaCalzados.Remove(Zapatos_de_Tacon);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked && (comboBox12.Text.Length > 0) && (comboBox11.Text.Length > 0))
            {
                Tenis_Lona.setSize(comboBox12.Text);
                Tenis_Lona.setUnidades(int.Parse(comboBox11.Text));
                ListaCalzados.Add(Tenis_Lona);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaCalzados.Remove(Tenis_Lona);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void BotonEnviarCarrito_Click(object sender, EventArgs e)
        {
            for(int i=0; i<ListaCalzados.Count;i++)
            {
                Pedido.agregarArticulos(ListaCalzados[i]);
            }
            MessageBox.Show("Agregados al carrito.");
        }
    }
    
}
