using Sistema_de_gestion_de_Pacientes.Entidades;
using Sistema_de_gestion_de_Pacientes.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_gestion_de_Pacientes.Vistas
{
    public partial class Editar : Form
    {
        private readonly GestorPacientes gestorPacientes = new GestorPacientes();
        private readonly int _id;
        public Editar(int id)
        {
            InitializeComponent();
        _id = id;

            // Cargar los datos del paciente al abrir el formulario de edición
            // Esto permite que el usuario vea y modifique los valores actuales
            var lista = gestorPacientes.encontrarPacientePorID(_id);
            if (lista != null && lista.Count > 0)
            {
                Paciente existente = lista[0];
                // Rellenar los controles con los datos existentes
                txtNombre2.Text = existente.NombreCompleto;
                txtEdad2.Text = existente.Edad.ToString();
                txtDiagnostico2.Text = existente.Diagnostico;
                dtFecha2.Value = existente.FechaIngreso;

                // Seleccionar sexo
                combSexo2.SelectedItem = existente.Sexo == Sexo.Masculino ? "Masculino" : "Femenino";

                // Seleccionar el estado correspondiente en el ComboBox
                switch (existente.Estado)
                {
                    case EstadoPaciente.Ingresado:
                        combEstado2.SelectedItem = "Ingresado";
                        break;
                    case EstadoPaciente.EnObservacion:
                        combEstado2.SelectedItem = "EnObservacion";
                        break;
                    case EstadoPaciente.DeAlta:
                        combEstado2.SelectedItem = "DeAlta";
                        break;
                    case EstadoPaciente.Hospitalizado:
                        combEstado2.SelectedItem = "Hospitalizado";
                        break;
                    default:
                        // No hacer nada si no coincide
                        break;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente();

            try
            {

                p.NombreCompleto = txtNombre2.Text;
                p.Edad = int.Parse(txtEdad2.Text);
                p.Diagnostico = txtDiagnostico2.Text;
                if (combSexo2.SelectedItem.ToString() == "Masculino")
                {
                    p.Sexo = Sexo.Masculino;
                }
                else if (combSexo2.SelectedItem.ToString() == "Femenino")
                {
                    p.Sexo = Sexo.Femenino;
                }
                else
                {
                    MessageBox.Show("Seleccione un sexo válido.");
                    return;
                }


                // Mapear la selección del ComboBox de estados al enum
                string estadoSel = combEstado2.SelectedItem?.ToString();
                if (estadoSel == "Ingresado")
                {
                    p.Estado = EstadoPaciente.Ingresado;
                }
                else if (estadoSel == "EnObservacion")
                {
                    p.Estado = EstadoPaciente.EnObservacion;
                }
                else if (estadoSel == "DeAlta")
                {
                    p.Estado = EstadoPaciente.DeAlta;
                }
                else if (estadoSel == "Hospitalizado")
                {
                    p.Estado = EstadoPaciente.Hospitalizado;
                }
                else
                {
                    MessageBox.Show("Seleccione un estado válido.");
                    return;
                }

                p.FechaIngreso = (DateTime)dtFecha2.Value;
            }
            catch (Exception Err)
            {
                // Capturamos errores de validación/parseo y avisamos al usuario
                MessageBox.Show("Rellene todos los campos y/o revise que sean validos.", "Error"); return;
            }

            DialogResult dialogRes = MessageBox.Show("¿Desea registrar al paciente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogRes == DialogResult.Yes)
            {
                gestorPacientes.editarPaciente(_id, p);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Registro cancelado.");
                this.Dispose();
            }
        }
    }
}
