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
    
    public partial class UsuarioForm : Form
    {
        private bool mover = false;
        public UsuarioForm()
        {
            InitializeComponent();
        }
        private void AbrirFormHijas(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void UsuarioForm_Load(object sender, EventArgs e)
        {

        }
        
        private void InicioSesionBoton_Click(object sender, EventArgs e)
        {
            inicioSecionForm.Show();
            this.Close();

        }

        private void NuevoUsuarioBoton_Click(object sender, EventArgs e)
        {
            nuevoUsuarioForm.Show();
            this.Close();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
        }

        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panelSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void BotonCerrarSUP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BotonMazimizar_Click(object sender, EventArgs e)
        {
            BotonMazimizar.Visible = false;
            BotonRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void BotonRestaurar_Click(object sender, EventArgs e)
        {
            BotonRestaurar.Visible = false;
            BotonMazimizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
