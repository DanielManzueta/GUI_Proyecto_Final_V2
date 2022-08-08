namespace GUI_Proyecto_Final_V2
{
    partial class UsuarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForm));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.BotonMinimizar = new System.Windows.Forms.Button();
            this.BotonRestaurar = new System.Windows.Forms.Button();
            this.BotonCerrarSUP = new System.Windows.Forms.Button();
            this.BotonMazimizar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.NuevoUsuarioBoton = new System.Windows.Forms.Button();
            this.InicioSesionBoton = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSuperior.Controls.Add(this.BotonMinimizar);
            this.panelSuperior.Controls.Add(this.BotonRestaurar);
            this.panelSuperior.Controls.Add(this.BotonCerrarSUP);
            this.panelSuperior.Controls.Add(this.BotonMazimizar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1000, 49);
            this.panelSuperior.TabIndex = 3;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.panelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            this.panelSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseUp);
            // 
            // BotonMinimizar
            // 
            this.BotonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinimizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BotonMinimizar.Image")));
            this.BotonMinimizar.Location = new System.Drawing.Point(835, 0);
            this.BotonMinimizar.Name = "BotonMinimizar";
            this.BotonMinimizar.Size = new System.Drawing.Size(50, 50);
            this.BotonMinimizar.TabIndex = 3;
            this.BotonMinimizar.UseVisualStyleBackColor = false;
            this.BotonMinimizar.Click += new System.EventHandler(this.BotonMinimizar_Click);
            // 
            // BotonRestaurar
            // 
            this.BotonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonRestaurar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BotonRestaurar.Image")));
            this.BotonRestaurar.Location = new System.Drawing.Point(891, 0);
            this.BotonRestaurar.Name = "BotonRestaurar";
            this.BotonRestaurar.Size = new System.Drawing.Size(50, 50);
            this.BotonRestaurar.TabIndex = 2;
            this.BotonRestaurar.UseVisualStyleBackColor = false;
            this.BotonRestaurar.Visible = false;
            this.BotonRestaurar.Click += new System.EventHandler(this.BotonRestaurar_Click);
            // 
            // BotonCerrarSUP
            // 
            this.BotonCerrarSUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrarSUP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonCerrarSUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrarSUP.Image = ((System.Drawing.Image)(resources.GetObject("BotonCerrarSUP.Image")));
            this.BotonCerrarSUP.Location = new System.Drawing.Point(947, -1);
            this.BotonCerrarSUP.Name = "BotonCerrarSUP";
            this.BotonCerrarSUP.Size = new System.Drawing.Size(50, 50);
            this.BotonCerrarSUP.TabIndex = 0;
            this.BotonCerrarSUP.UseVisualStyleBackColor = false;
            this.BotonCerrarSUP.Click += new System.EventHandler(this.BotonCerrarSUP_Click);
            // 
            // BotonMazimizar
            // 
            this.BotonMazimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMazimizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonMazimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMazimizar.Image = ((System.Drawing.Image)(resources.GetObject("BotonMazimizar.Image")));
            this.BotonMazimizar.Location = new System.Drawing.Point(891, 0);
            this.BotonMazimizar.Name = "BotonMazimizar";
            this.BotonMazimizar.Size = new System.Drawing.Size(50, 50);
            this.BotonMazimizar.TabIndex = 1;
            this.BotonMazimizar.UseVisualStyleBackColor = false;
            this.BotonMazimizar.Click += new System.EventHandler(this.BotonMazimizar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.BotonCerrar);
            this.panelContenedor.Controls.Add(this.NuevoUsuarioBoton);
            this.panelContenedor.Controls.Add(this.InicioSesionBoton);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 49);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1000, 451);
            this.panelContenedor.TabIndex = 4;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonCerrar.Location = new System.Drawing.Point(218, 292);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(564, 67);
            this.BotonCerrar.TabIndex = 5;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // NuevoUsuarioBoton
            // 
            this.NuevoUsuarioBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevoUsuarioBoton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NuevoUsuarioBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoUsuarioBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoUsuarioBoton.Location = new System.Drawing.Point(218, 187);
            this.NuevoUsuarioBoton.Name = "NuevoUsuarioBoton";
            this.NuevoUsuarioBoton.Size = new System.Drawing.Size(564, 67);
            this.NuevoUsuarioBoton.TabIndex = 4;
            this.NuevoUsuarioBoton.Text = "Nuevo Usuario";
            this.NuevoUsuarioBoton.UseVisualStyleBackColor = false;
            this.NuevoUsuarioBoton.Click += new System.EventHandler(this.NuevoUsuarioBoton_Click);
            // 
            // InicioSesionBoton
            // 
            this.InicioSesionBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InicioSesionBoton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InicioSesionBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioSesionBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InicioSesionBoton.Location = new System.Drawing.Point(218, 92);
            this.InicioSesionBoton.Name = "InicioSesionBoton";
            this.InicioSesionBoton.Size = new System.Drawing.Size(564, 61);
            this.InicioSesionBoton.TabIndex = 3;
            this.InicioSesionBoton.Text = "Iniciar Sesion";
            this.InicioSesionBoton.UseVisualStyleBackColor = false;
            this.InicioSesionBoton.Click += new System.EventHandler(this.InicioSesionBoton_Click);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.panelSuperior.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        InicioSecionForm inicioSecionForm = new InicioSecionForm();
        NuevoUsuarioForm nuevoUsuarioForm = new NuevoUsuarioForm();
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Button NuevoUsuarioBoton;
        private System.Windows.Forms.Button InicioSesionBoton;
        private System.Windows.Forms.Button BotonMinimizar;
        private System.Windows.Forms.Button BotonRestaurar;
        private System.Windows.Forms.Button BotonMazimizar;
        private System.Windows.Forms.Button BotonCerrarSUP;
    }
}

