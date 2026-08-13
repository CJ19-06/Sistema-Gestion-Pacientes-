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
            txtDiagnostico2 = new TextBox();
            txtEdad2 = new TextBox();
            lbFecha = new Label();
            lbEstado = new Label();
            lbSexo = new Label();
            lbDiagnostico = new Label();
            lbEdad = new Label();
            lbNombre = new Label();
            dtFecha2 = new DateTimePicker();
            combEstado2 = new ComboBox();
            combSexo2 = new ComboBox();
            txtNombre2 = new TextBox();
            lbTitulo = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDiagnostico2
            // 
            txtDiagnostico2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiagnostico2.Location = new Point(284, 255);
            txtDiagnostico2.Name = "txtDiagnostico2";
            txtDiagnostico2.Size = new Size(193, 35);
            txtDiagnostico2.TabIndex = 29;
            // 
            // txtEdad2
            // 
            txtEdad2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdad2.Location = new Point(284, 107);
            txtEdad2.Name = "txtEdad2";
            txtEdad2.Size = new Size(193, 35);
            txtEdad2.TabIndex = 28;
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
            lbDiagnostico.Click += label5_Click;
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
            // dtFecha2
            // 
            dtFecha2.Location = new Point(12, 264);
            dtFecha2.Name = "dtFecha2";
            dtFecha2.Size = new Size(230, 23);
            dtFecha2.TabIndex = 21;
            // 
            // combEstado2 - elementos consistentes con el enum EstadoPaciente
            combEstado2.Font = new Font("Segoe UI", 16F);
            combEstado2.FormattingEnabled = true;
            combEstado2.Items.AddRange(new object[] { "Ingresado", "EnObservacion", "DeAlta", "Hospitalizado" });
            combEstado2.Location = new Point(285, 178);
            combEstado2.Name = "combEstado2";
            combEstado2.Size = new Size(192, 38);
            combEstado2.TabIndex = 20;
            // 
            // combSexo2
            // 
            combSexo2.Font = new Font("Segoe UI", 16F);
            combSexo2.FormattingEnabled = true;
            combSexo2.Items.AddRange(new object[] { "Masculino", "Femenino" });
            combSexo2.Location = new Point(14, 178);
            combSexo2.Name = "combSexo2";
            combSexo2.Size = new Size(193, 38);
            combSexo2.TabIndex = 19;
            // 
            // txtNombre2
            // 
            txtNombre2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre2.Location = new Point(14, 107);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(193, 35);
            txtNombre2.TabIndex = 18;
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
            // button1
            // 
            button1.Location = new Point(156, 322);
            button1.Name = "button1";
            button1.Size = new Size(147, 46);
            button1.TabIndex = 30;
            button1.Text = "Confirmar edicion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 380);
            Controls.Add(button1);
            Controls.Add(txtDiagnostico2);
            Controls.Add(txtEdad2);
            Controls.Add(lbFecha);
            Controls.Add(lbEstado);
            Controls.Add(lbSexo);
            Controls.Add(lbDiagnostico);
            Controls.Add(lbEdad);
            Controls.Add(lbNombre);
            Controls.Add(dtFecha2);
            Controls.Add(combEstado2);
            Controls.Add(combSexo2);
            Controls.Add(txtNombre2);
            Controls.Add(lbTitulo);
            Name = "Editar";
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDiagnostico2;
        private TextBox txtEdad2;
        private Label lbFecha;
        private Label lbEstado;
        private Label lbSexo;
        private Label lbDiagnostico;
        private Label lbEdad;
        private Label lbNombre;
        private DateTimePicker dtFecha2;
        private ComboBox combEstado2;
        private ComboBox combSexo2;
        private TextBox txtNombre2;
        private Label lbTitulo;
        private Button button1;
    }
}