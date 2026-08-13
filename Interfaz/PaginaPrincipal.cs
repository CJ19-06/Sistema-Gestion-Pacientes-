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
            dgvListaPacientes.DataSource = GestorPacientes.pacientes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new DatosPaciente().ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgvListaPacientes.DataSource = null;
            dgvListaPacientes.DataSource = GestorPacientes.pacientes;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Paciente p = (Paciente)dgvListaPacientes.CurrentRow.DataBoundItem;
            new Editar(p.Id).ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Paciente p = (Paciente)dgvListaPacientes.CurrentRow.DataBoundItem;
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
                dgvListaPacientes.DataSource = null;
                dgvListaPacientes.DataSource = GestorPacientes.pacientes;
            }
            else
            {
                // Si el usuario cancela, no hacemos nada
                return;
            }

        }

        private void txtBuscarNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBuscarNombre.Text))
            {
                dgvListaPacientes.DataSource = gestorPacientes.ObtenerPacientePorNombre(txtBuscarNombre.Text);
            }
            else { dgvListaPacientes.DataSource = GestorPacientes.pacientes; }

        }

        private void txtBuscaPorId_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBuscaPorId.Text))
            {
                dgvListaPacientes.DataSource = gestorPacientes.encontrarPacientePorID(int.Parse(txtBuscaPorId.Text));
            }
            else { dgvListaPacientes.DataSource = GestorPacientes.pacientes; }

        }
    }
}
