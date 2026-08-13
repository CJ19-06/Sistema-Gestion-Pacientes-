namespace Sistema_de_gestion_de_Pacientes
{
    partial class PaginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            tlsBarraHerramientas = new ToolStrip();
            txtBuscarNombre = new ToolStripTextBox();
            btnRefrescar = new ToolStripButton();
            btnAgregar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnBorrar = new ToolStripButton();
            txtBuscaPorId = new ToolStripTextBox();
            dgvListaPacientes = new DataGridView();
            tlsBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPacientes).BeginInit();
            SuspendLayout();
            // 
            // tlsBarraHerramientas
            // 
            tlsBarraHerramientas.Items.AddRange(new ToolStripItem[] { txtBuscarNombre, btnRefrescar, btnAgregar, btnEditar, btnBorrar, txtBuscaPorId });
            tlsBarraHerramientas.Location = new Point(0, 0);
            tlsBarraHerramientas.Name = "tlsBarraHerramientas";
            tlsBarraHerramientas.Size = new Size(877, 25);
            tlsBarraHerramientas.TabIndex = 0;
            tlsBarraHerramientas.Text = "tlsBarraHerramientas";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(200, 25);
            txtBuscarNombre.Click += txtBuscarNombre_Click;
            txtBuscarNombre.TextChanged += txtBuscarNombre_TextChanged;
            // 
            // btnRefrescar
            // 
            btnRefrescar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRefrescar.Image = (Image)resources.GetObject("btnRefrescar.Image");
            btnRefrescar.ImageTransparentColor = Color.Magenta;
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(23, 22);
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageTransparentColor = Color.Magenta;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(23, 22);
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(23, 22);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
            btnBorrar.ImageTransparentColor = Color.Magenta;
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(23, 22);
            btnBorrar.Text = "Borrar";
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtBuscaPorId
            // 
            txtBuscaPorId.Name = "txtBuscaPorId";
            txtBuscaPorId.Size = new Size(100, 25);
            txtBuscaPorId.TextChanged += txtBuscaPorId_Click;
            // 
            // dgvListaPacientes
            // 
            dgvListaPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPacientes.Dock = DockStyle.Fill;
            dgvListaPacientes.Location = new Point(0, 25);
            dgvListaPacientes.Name = "dgvListaPacientes";
            dgvListaPacientes.Size = new Size(877, 425);
            dgvListaPacientes.TabIndex = 1;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 450);
            Controls.Add(dgvListaPacientes);
            Controls.Add(tlsBarraHerramientas);
            Name = "PaginaPrincipal";
            Text = "PacientePaginaPrincial";
            tlsBarraHerramientas.ResumeLayout(false);
            tlsBarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tlsBarraHerramientas;
        private ToolStripTextBox txtBuscarNombre;
        private DataGridView dgvListaPacientes;
        private ToolStripButton btnRefrescar;
        private ToolStripButton btnAgregar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnBorrar;
        private ToolStripTextBox txtBuscaPorId;
    }
}
