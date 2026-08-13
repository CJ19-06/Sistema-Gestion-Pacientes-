namespace Sistema_de_gestion_de_Pacientes
{
    partial class DatosPaciente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitulo = new Label();
            txtNombre = new TextBox();
            combSexo = new ComboBox();
            combEstado = new ComboBox();
            dtFecha = new DateTimePicker();
            lbNombre = new Label();
            lbEdad = new Label();
            lbDiagnostico = new Label();
            lbSexo = new Label();
            lbEstado = new Label();
            lbFecha = new Label();
            txtEdad = new TextBox();
            txtDiagnostico = new TextBox();
            registroButton = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(93, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(311, 47);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Datos Del Paciente";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(14, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 35);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // combSexo
            // 
            combSexo.Font = new Font("Segoe UI", 16F);
            combSexo.FormattingEnabled = true;
            combSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            combSexo.Location = new Point(14, 178);
            combSexo.Name = "combSexo";
            combSexo.Size = new Size(193, 38);
            combSexo.TabIndex = 3;
            // 
            // combEstado - lista de estados permitidos (mostrar textos consistentes con el enum)
            combEstado.Font = new Font("Segoe UI", 16F);
            combEstado.FormattingEnabled = true;
            combEstado.Items.AddRange(new object[] { "Ingresado", "EnObservacion", "DeAlta", "Hospitalizado" });
            combEstado.Location = new Point(285, 178);
            combEstado.Name = "combEstado";
            combEstado.Size = new Size(192, 38);
            combEstado.TabIndex = 4;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(14, 255);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(230, 23);
            dtFecha.TabIndex = 5;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(12, 73);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(140, 21);
            lbNombre.TabIndex = 8;
            lbNombre.Text = "Nombre Completo";
            lbNombre.Click += label2_Click;
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEdad.Location = new Point(285, 73);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(44, 21);
            lbEdad.TabIndex = 9;
            lbEdad.Text = "Edad";
            lbEdad.TextAlign = ContentAlignment.TopCenter;
            lbEdad.Click += label3_Click;
            // 
            // lbDiagnostico
            // 
            lbDiagnostico.AutoSize = true;
            lbDiagnostico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDiagnostico.Location = new Point(284, 232);
            lbDiagnostico.Name = "lbDiagnostico";
            lbDiagnostico.Size = new Size(92, 21);
            lbDiagnostico.TabIndex = 11;
            lbDiagnostico.Text = "Diagnostico";
            lbDiagnostico.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbSexo
            // 
            lbSexo.AutoSize = true;
            lbSexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSexo.Location = new Point(12, 154);
            lbSexo.Name = "lbSexo";
            lbSexo.RightToLeft = RightToLeft.Yes;
            lbSexo.Size = new Size(43, 21);
            lbSexo.TabIndex = 12;
            lbSexo.Text = "Sexo";
            lbSexo.Click += label6_Click;
            // 
            // lbEstado
            // 
            lbEstado.AutoSize = true;
            lbEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstado.Location = new Point(284, 154);
            lbEstado.Name = "lbEstado";
            lbEstado.RightToLeft = RightToLeft.Yes;
            lbEstado.Size = new Size(56, 21);
            lbEstado.TabIndex = 13;
            lbEstado.Text = "Estado";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFecha.Location = new Point(12, 222);
            lbFecha.Name = "lbFecha";
            lbFecha.RightToLeft = RightToLeft.Yes;
            lbFecha.Size = new Size(50, 21);
            lbFecha.TabIndex = 14;
            lbFecha.Text = "Fecha";
            lbFecha.Click += label8_Click;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdad.Location = new Point(284, 107);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(193, 35);
            txtEdad.TabIndex = 15;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiagnostico.Location = new Point(284, 255);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(193, 35);
            txtDiagnostico.TabIndex = 16;
            // 
            // registroButton
            // 
            registroButton.Location = new Point(150, 316);
            registroButton.Name = "registroButton";
            registroButton.Size = new Size(157, 43);
            registroButton.TabIndex = 17;
            registroButton.Text = "Completar registro";
            registroButton.UseVisualStyleBackColor = true;
            registroButton.Click += registroButton_Click;
            // 
            // DatosPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 371);
            Controls.Add(registroButton);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtEdad);
            Controls.Add(lbFecha);
            Controls.Add(lbEstado);
            Controls.Add(lbSexo);
            Controls.Add(lbDiagnostico);
            Controls.Add(lbEdad);
            Controls.Add(lbNombre);
            Controls.Add(dtFecha);
            Controls.Add(combEstado);
            Controls.Add(combSexo);
            Controls.Add(txtNombre);
            Controls.Add(lbTitulo);
            Name = "DatosPaciente";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private TextBox txtNombre;
        private ComboBox combSexo;
        private ComboBox combEstado;
        private DateTimePicker dtFecha;
        private Label lbNombre;
        private Label lbEdad;
        private Label lbDiagnostico;
        private Label lbSexo;
        private Label lbEstado;
        private Label lbFecha;
        private TextBox txtEdad;
        private TextBox txtDiagnostico;
        private Button registroButton;
    }
}
