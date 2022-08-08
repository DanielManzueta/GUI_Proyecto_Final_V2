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
    

    public partial class ElectronicosForm : Form
    {
        public ElectronicosForm()
        {
            InitializeComponent();
        }

        

        private void ElectronicosForm_Load(object sender, EventArgs e)
        {
            //
            //N64 -> Consola
            //
            N64.setNombre("Nintendo 64");
            N64.setMarca("Nintendo");
            N64.setPrecio(6500);
            N64.setColor("Gris");
            N64.setDimension("2.87×10.23×7.48");
            N64.setProcesador("NEC VR4300 de 64-bit a 93.7 MHz");
            N64.setModelo("Nintendo 64");
            N64.setRAM("8 GB");
            N64.setGPU("62.5 MHz");
            //
            //Lenovo_V15
            //
            Lenovo_V15.setNombre("Lenovo V15");
            Lenovo_V15.setMarca("Lenovo");
            Lenovo_V15.setPrecio(11612.11);
            Lenovo_V15.setColor("Negro");
            Lenovo_V15.setDimension("362.2mm x 251.5mm x 19.9mm");
            Lenovo_V15.setProcesador(" Intel Core i5-1035G1");
            Lenovo_V15.setModelo("V15");
            Lenovo_V15.setRAM("8 GB");
            Lenovo_V15.setHDD("1 TB");
            Lenovo_V15.setGPU("Intel Iris Plus");
            //
            //Iphone 11 pro max
            //
            Iphone_11_pro_max.setNombre("Iphone 11 pro max");
            Iphone_11_pro_max.setMarca("Iphone");
            Iphone_11_pro_max.setPrecio(35000);
            Iphone_11_pro_max.setColor("Verde Noche");
            Iphone_11_pro_max.setDimension("7.78 cm x 15.8 cm x 0.81 cm");
            Iphone_11_pro_max.setProcesador("iOS 13");
            Iphone_11_pro_max.setModelo("11 PRO MAX");
            Iphone_11_pro_max.setRAM("6 GB");
            Iphone_11_pro_max.setHDD("128 GB");
            //
            //Chromebook Galaxy XE930QCA-K01US-RB
            //
            Chromebook_Galaxy.setNombre("Chromebook Galaxy XE930QCA-K01US-RB");
            Chromebook_Galaxy.setMarca("Samsung");
            Chromebook_Galaxy.setPrecio(32999.45);
            Chromebook_Galaxy.setColor("Rojo");
            Chromebook_Galaxy.setDimension("302,6 x 203,2 x 9,9 mm");
            Chromebook_Galaxy.setProcesador("Chromebook_Galaxy");
            Chromebook_Galaxy.setRAM("16 GB LPDDR3");
        }
        private void button1_Click(object sender, EventArgs e)
        {

            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + N64.getNombre() + "\nMarca: " + N64.getMarca() + 
            "\nPrecio: " + N64.getPrecio().ToString() + "\nColor: " + N64.getColor() +
            "\nDimension: " + N64.getDimension() + "\nProcesador: " + N64.getProcesador()
            + "\nModelo: " + N64.getModelo() + "\nRAM: " + N64.getRAM() + "\nGPU: " + N64.getGPU());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Lenovo_V15.getNombre() + "\nMarca: "
            + Lenovo_V15.getMarca() + "\nPrecio: " + Lenovo_V15.getPrecio().ToString() + "\nColor: "
            + Lenovo_V15.getColor() + "\nDimension: " + Lenovo_V15.getDimension() +
            "\nProcesador: " + Lenovo_V15.getProcesador() + "\nModelo: " + Lenovo_V15.getModelo()
            + "\nRAM: " + Lenovo_V15.getRAM() + "\nHDD: " + Lenovo_V15.getHDD() + "\nGPU: " + Lenovo_V15.getGPU());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Iphone_11_pro_max.getNombre() + "\nMarca: "
            + Iphone_11_pro_max.getMarca() + "\nPrecio: " + Iphone_11_pro_max.getPrecio().ToString() +
            "\nColor: " + Iphone_11_pro_max.getColor() + "Dimension: " + Iphone_11_pro_max.getDimension() +
            "Procesador: " + Iphone_11_pro_max.getProcesador() + "Modelo: " + Iphone_11_pro_max.getModelo()
            + "RAM: " + Iphone_11_pro_max.getRAM() + "HDD: " + Iphone_11_pro_max.getHDD());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DetallesArticulosForm().Show();
            DetallesArticulosForm.setTextBox("Nombre: " + Chromebook_Galaxy.getNombre() + "\nMarca: " +
            Chromebook_Galaxy.getMarca() + "\nPrecio: " + Chromebook_Galaxy.getPrecio().ToString() +
            "\nColor: " + Chromebook_Galaxy.getColor() + "Dimension: " + Chromebook_Galaxy.getDimension() +
            "Procesador: " + Chromebook_Galaxy.getProcesador() + "RAM: " + Chromebook_Galaxy.getRAM());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && (comboBox3.Text.Length > 0))
            {
                N64.setUnidades(int.Parse(comboBox3.Text));
                ListaELectronicos.Add(N64);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaELectronicos.Remove(N64);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && (comboBox1.Text.Length > 0))
            {
                Lenovo_V15.setUnidades(int.Parse(comboBox1.Text));
                ListaELectronicos.Add(Lenovo_V15);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaELectronicos.Remove(Lenovo_V15);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked && (comboBox2.Text.Length > 0))
            {
                Iphone_11_pro_max.setUnidades(int.Parse(comboBox2.Text));
                ListaELectronicos.Add(Iphone_11_pro_max);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaELectronicos.Remove(Iphone_11_pro_max);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && (comboBox4.Text.Length > 0))
            {
                Chromebook_Galaxy.setUnidades(int.Parse(comboBox4.Text));
                ListaELectronicos.Add(Chromebook_Galaxy);
                MessageBox.Show("Agregado a lista.");
            }
            else
            {
                ListaELectronicos.Remove(Chromebook_Galaxy);
                MessageBox.Show("Removido de la lista.");
            }
        }

        private void BotonEnviarCarrito_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListaELectronicos.Count; i++)
            {
                Pedido.agregarArticulos(ListaELectronicos[i]);
            }
            MessageBox.Show("Agregados al carrito.");
        }
    }
}
