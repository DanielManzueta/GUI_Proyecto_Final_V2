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
    public partial class MenuPrincipalForm : Form
    {
        private int cont = 0;
        public MenuPrincipalForm()
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

        private void BotonArticulo_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                SubPanelArticulos.Visible = true;
                BotonCalzado.Visible = true;
                BotonRopa.Visible = true;
                BotonElectronicos.Visible = true;
                PanelCarrito.Visible = false;
                BotonCarrito.Visible = false;
                cont = 1;

            }
            else if (cont == 1)
            {
                SubPanelArticulos.Visible = false;
                BotonCalzado.Visible = false;
                BotonRopa.Visible = false;
                BotonElectronicos.Visible = false;
                PanelCarrito.Visible = true;
                BotonCarrito.Visible = true;
                cont = 0;
            }
        }
        private void BotonRopa_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new RopaForm());
        }

        private void BotonCalzado_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new CalzadoForm());
        }

        private void BotonElectronicos_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new ElectronicosForm());
        }
        private void BotonCarrito_Click(object sender, EventArgs e)
        {
            AbrirFormHijas(new CarritoForm());
        }
        private void BotonInicio_Click(object sender, EventArgs e)
        {
            SubPanelArticulos.Visible = false;
            BotonCarrito.Visible = true;
            PanelCarrito.Visible=true;
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            AbrirFormHijas(new ImagenInicioForm());

        }

        private void CerrarSesionBoton_MouseHover(object sender, EventArgs e)
        {
            CerrarSesionBoton.BackColor= Color.White;
        }

        private void CerrarSesionBoton_MouseLeave(object sender, EventArgs e)
        {
            CerrarSesionBoton.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void CerrarSesionBoton_Click(object sender, EventArgs e)
        {
            this.Close();
            new UsuarioForm().Show();
        }

        private void BotonUsuario_Click(object sender, EventArgs e)
        {
            SubPanelArticulos.Visible = false;
            BotonCarrito.Visible = true;
            PanelCarrito.Visible = true;
            AbrirFormHijas(new UsuarioDetallesForm());
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
        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
