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
            toolStrip1 = new ToolStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            refreshBtn = new ToolStripButton();
            addEmployeeBtn = new ToolStripButton();
            editBtn = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            idTxtBox = new ToolStripTextBox();
            dglistapaciente = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dglistapaciente).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, refreshBtn, addEmployeeBtn, editBtn, toolStripButton4, idTxtBox });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(877, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(200, 25);
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // refreshBtn
            // 
            refreshBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            refreshBtn.Image = (Image)resources.GetObject("refreshBtn.Image");
            refreshBtn.ImageTransparentColor = Color.Magenta;
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(23, 22);
            refreshBtn.Text = "Refresh";
            refreshBtn.Click += refreshBtn_Click;
            // 
            // addEmployeeBtn
            // 
            addEmployeeBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            addEmployeeBtn.Image = (Image)resources.GetObject("addEmployeeBtn.Image");
            addEmployeeBtn.ImageTransparentColor = Color.Magenta;
            addEmployeeBtn.Name = "addEmployeeBtn";
            addEmployeeBtn.Size = new Size(23, 22);
            addEmployeeBtn.Text = "Agregar";
            addEmployeeBtn.Click += addEmployeeBtn_Click;
            // 
            // editBtn
            // 
            editBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            editBtn.Image = (Image)resources.GetObject("editBtn.Image");
            editBtn.ImageTransparentColor = Color.Magenta;
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(23, 22);
            editBtn.Text = "Editar";
            editBtn.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "Borrar";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // idTxtBox
            // 
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(100, 25);
            idTxtBox.TextChanged += idTxtBox_Click;
            // 
            // dglistapaciente
            // 
            dglistapaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dglistapaciente.Dock = DockStyle.Fill;
            dglistapaciente.Location = new Point(0, 25);
            dglistapaciente.Name = "dglistapaciente";
            dglistapaciente.Size = new Size(877, 425);
            dglistapaciente.TabIndex = 1;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 450);
            Controls.Add(dglistapaciente);
            Controls.Add(toolStrip1);
            Name = "PaginaPrincipal";
            Text = "PacientePaginaPrincial";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dglistapaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private DataGridView dglistapaciente;
        private ToolStripButton refreshBtn;
        private ToolStripButton addEmployeeBtn;
        private ToolStripButton editBtn;
        private ToolStripButton toolStripButton4;
        private ToolStripTextBox idTxtBox;
    }
}