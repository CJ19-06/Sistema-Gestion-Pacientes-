using Sistema_de_gestion_de_Pacientes.Entidades;
using Sistema_de_gestion_de_Pacientes.Servicios;
using Sistema_de_gestion_de_Pacientes.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_gestion_de_Pacientes
{
    public partial class PaginaPrincipal : Form
    {
        private readonly GestorPacientes gestorPacientes = new GestorPacientes();

        public PaginaPrincipal()
        {
            InitializeComponent();
            dglistapaciente.DataSource = GestorPacientes.pacientes;
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            new DatosPaciente().ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dglistapaciente.DataSource = null;
            dglistapaciente.DataSource = GestorPacientes.pacientes;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Paciente p = (Paciente)dglistapaciente.CurrentRow.DataBoundItem;
            new Editar(p.Id).ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Paciente p = (Paciente)dglistapaciente.CurrentRow.DataBoundItem;
            // Confirmación antes de eliminar el paciente
            DialogResult dialogRes = MessageBox.Show(
                "Desea eliminar el paciente?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogRes == DialogResult.Yes)
            {
                // Ejecutar la eliminación existente
                gestorPacientes.EliminarPaciente(p);
                dglistapaciente.DataSource = null;
                dglistapaciente.DataSource = GestorPacientes.pacientes;
            }
            else
            {
                // Si el usuario cancela, no hacemos nada
                return;
            }

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(toolStripTextBox1.Text))
            {
                dglistapaciente.DataSource = gestorPacientes.ObtenerPacientePorNombre(toolStripTextBox1.Text);
            }
            else { dglistapaciente.DataSource = GestorPacientes.pacientes; }

        }

        private void idTxtBox_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(idTxtBox.Text))
            {
                dglistapaciente.DataSource = gestorPacientes.encontrarPacientePorID(int.Parse(idTxtBox.Text));
            }
            else { dglistapaciente.DataSource = GestorPacientes.pacientes; }

        }
    }
}
