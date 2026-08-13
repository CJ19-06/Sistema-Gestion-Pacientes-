using Sistema_de_gestion_de_Pacientes.Entidades;
using Sistema_de_gestion_de_Pacientes.Servicios;

namespace Sistema_de_gestion_de_Pacientes
{
    // Formulario para crear un nuevo paciente
    // Contiene validaciones básicas y mapea los controles al objeto Paciente
    public partial class DatosPaciente : Form
    {
        private readonly GestorPacientes gestorPacientes = new GestorPacientes();
        public DatosPaciente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registroButton_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            // Intentamos asignar los valores de los controles al objeto Paciente
            //Usamos un try catch para capturar errores de parseo o validación y mostrar un mensaje al usuario
            try
            {
               
                p.NombreCompleto = txtNombre.Text;
                p.Edad = int.Parse(txtEdad.Text);
                p.Diagnostico = txtDiagnostico.Text;
                if (combSexo.SelectedItem.ToString() == "Masculino")
                {
                    p.Sexo = Sexo.Masculino;
                }
                else if (combSexo.SelectedItem.ToString() == "Femenino")
                {
                    p.Sexo = Sexo.Femenino;
                }
                else
                {
                    MessageBox.Show("Seleccione un sexo válido.");
                    return;
                }

                // Asignar estado según la opción seleccionada en el ComboBox
                string estadoSeleccionado = combEstado.SelectedItem?.ToString();
                if (estadoSeleccionado == "Ingresado")
                {
                    p.Estado = EstadoPaciente.Ingresado;
                }
                else if (estadoSeleccionado == "EnObservacion")
                {
                    p.Estado = EstadoPaciente.EnObservacion;
                }
                else if (estadoSeleccionado == "DeAlta")
                {
                    p.Estado = EstadoPaciente.DeAlta;
                }
                else if (estadoSeleccionado == "Hospitalizado")
                {
                    p.Estado = EstadoPaciente.Hospitalizado;
                }
                else
                {
                    MessageBox.Show("Seleccione un estado válido.");
                    return;
                }

                p.FechaIngreso = (DateTime)dtFecha.Value;
            }
            catch (Exception Err)
            {
                // Capturamos errores de parseo/validación y avisamos al usuario
                MessageBox.Show("Rellene todos los campos y/o revise que sean validos.", "Error"); return;
            }
    
            DialogResult dialogRes = MessageBox.Show("¿Desea registrar al paciente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogRes == DialogResult.Yes)
            {
                gestorPacientes.AgregarPaciente(p);
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
