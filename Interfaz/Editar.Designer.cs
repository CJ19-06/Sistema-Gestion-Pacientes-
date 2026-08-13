namespace Sistema_de_gestion_de_Pacientes.Vistas
{
    partial class Editar
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
            txtDiagnosticoEdicion = new TextBox();
            txtEdadEdicion = new TextBox();
            lbFecha = new Label();
            lbEstado = new Label();
            lbSexo = new Label();
            lbDiagnostico = new Label();
            lbEdad = new Label();
            lbNombre = new Label();
            dtFechaEdicion = new DateTimePicker();
            cmbEstadoEdicion = new ComboBox();
            cmbSexoEdicion = new ComboBox();
            txtNombreEdicion = new TextBox();
            lbTitulo = new Label();
            btnConfirmarEdicion = new Button();
            SuspendLayout();
            // 
            // txtDiagnosticoEdicion
            // 
            txtDiagnosticoEdicion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiagnosticoEdicion.Location = new Point(284, 255);
            txtDiagnosticoEdicion.Name = "txtDiagnosticoEdicion";
            txtDiagnosticoEdicion.Size = new Size(193, 35);
            txtDiagnosticoEdicion.TabIndex = 29;
            // 
            // txtEdadEdicion
            // 
            txtEdadEdicion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdadEdicion.Location = new Point(284, 107);
            txtEdadEdicion.Name = "txtEdadEdicion";
            txtEdadEdicion.Size = new Size(193, 35);
            txtEdadEdicion.TabIndex = 28;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFecha.Location = new Point(12, 240);
            lbFecha.Name = "lbFecha";
            lbFecha.RightToLeft = RightToLeft.Yes;
            lbFecha.Size = new Size(50, 21);
            lbFecha.TabIndex = 27;
            lbFecha.Text = "Fecha";
            // 
            // lbEstado
            // 
            lbEstado.AutoSize = true;
            lbEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstado.Location = new Point(284, 154);
            lbEstado.Name = "lbEstado";
            lbEstado.RightToLeft = RightToLeft.Yes;
            lbEstado.Size = new Size(56, 21);
            lbEstado.TabIndex = 26;
            lbEstado.Text = "Estado";
            // 
            // lbSexo
            // 
            lbSexo.AutoSize = true;
            lbSexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSexo.Location = new Point(12, 154);
            lbSexo.Name = "lbSexo";
            lbSexo.RightToLeft = RightToLeft.Yes;
            lbSexo.Size = new Size(43, 21);
            lbSexo.TabIndex = 25;
            lbSexo.Text = "Sexo";
            // 
            // lbDiagnostico
            // 
            lbDiagnostico.AutoSize = true;
            lbDiagnostico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDiagnostico.Location = new Point(284, 231);
            lbDiagnostico.Name = "lbDiagnostico";
            lbDiagnostico.Size = new Size(92, 21);
            lbDiagnostico.TabIndex = 24;
            lbDiagnostico.Text = "Diagnostico";
            lbDiagnostico.TextAlign = ContentAlignment.TopCenter;
            lbDiagnostico.Click += lbDiagnostico_Click;
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEdad.Location = new Point(284, 83);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(44, 21);
            lbEdad.TabIndex = 23;
            lbEdad.Text = "Edad";
            lbEdad.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(12, 83);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(140, 21);
            lbNombre.TabIndex = 22;
            lbNombre.Text = "Nombre Completo";
            // 
            // dtFechaEdicion
            // 
            dtFechaEdicion.Location = new Point(12, 264);
            dtFechaEdicion.Name = "dtFechaEdicion";
            dtFechaEdicion.Size = new Size(230, 23);
            dtFechaEdicion.TabIndex = 21;
            // 
            // cmbEstadoEdicion - elementos consistentes con el enum EstadoPaciente
            cmbEstadoEdicion.Font = new Font("Segoe UI", 16F);
            cmbEstadoEdicion.FormattingEnabled = true;
            cmbEstadoEdicion.Items.AddRange(new object[] { "Ingresado", "EnObservacion", "DeAlta", "Hospitalizado" });
            cmbEstadoEdicion.Location = new Point(285, 178);
            cmbEstadoEdicion.Name = "cmbEstadoEdicion";
            cmbEstadoEdicion.Size = new Size(192, 38);
            cmbEstadoEdicion.TabIndex = 20;
            // 
            // cmbSexoEdicion
            // 
            cmbSexoEdicion.Font = new Font("Segoe UI", 16F);
            cmbSexoEdicion.FormattingEnabled = true;
            cmbSexoEdicion.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbSexoEdicion.Location = new Point(14, 178);
            cmbSexoEdicion.Name = "cmbSexoEdicion";
            cmbSexoEdicion.Size = new Size(193, 38);
            cmbSexoEdicion.TabIndex = 19;
            // 
            // txtNombreEdicion
            // 
            txtNombreEdicion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEdicion.Location = new Point(14, 107);
            txtNombreEdicion.Name = "txtNombreEdicion";
            txtNombreEdicion.Size = new Size(193, 35);
            txtNombreEdicion.TabIndex = 18;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(93, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(311, 47);
            lbTitulo.TabIndex = 17;
            lbTitulo.Text = "Datos Del Paciente";
            // 
            // btnConfirmarEdicion
            // 
            btnConfirmarEdicion.Location = new Point(156, 322);
            btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            btnConfirmarEdicion.Size = new Size(147, 46);
            btnConfirmarEdicion.TabIndex = 30;
            btnConfirmarEdicion.Text = "Confirmar edicion";
            btnConfirmarEdicion.UseVisualStyleBackColor = true;
            btnConfirmarEdicion.Click += btnConfirmarEdicion_Click;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 380);
            Controls.Add(btnConfirmarEdicion);
            Controls.Add(txtDiagnosticoEdicion);
            Controls.Add(txtEdadEdicion);
            Controls.Add(lbFecha);
            Controls.Add(lbEstado);
            Controls.Add(lbSexo);
            Controls.Add(lbDiagnostico);
            Controls.Add(lbEdad);
            Controls.Add(lbNombre);
            Controls.Add(dtFechaEdicion);
            Controls.Add(cmbEstadoEdicion);
            Controls.Add(cmbSexoEdicion);
            Controls.Add(txtNombreEdicion);
            Controls.Add(lbTitulo);
            Name = "Editar";
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDiagnosticoEdicion;
        private TextBox txtEdadEdicion;
        private Label lbFecha;
        private Label lbEstado;
        private Label lbSexo;
        private Label lbDiagnostico;
        private Label lbEdad;
        private Label lbNombre;
        private DateTimePicker dtFechaEdicion;
        private ComboBox cmbEstadoEdicion;
        private ComboBox cmbSexoEdicion;
        private TextBox txtNombreEdicion;
        private Label lbTitulo;
        private Button btnConfirmarEdicion;
    }
}
