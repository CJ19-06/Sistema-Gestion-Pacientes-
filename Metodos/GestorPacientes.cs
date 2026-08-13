using Sistema_de_gestion_de_Pacientes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;


namespace Sistema_de_gestion_de_Pacientes.Servicios
{
    // Gestor simple que mantiene la lista en memoria y ofrece operaciones CRUD
    public class GestorPacientes

    {
        // Lista compartida de pacientes mientras la aplicación está en ejecución
        // (se usa para mostrar en el DataGridView y realizar operaciones)
        public static List<Paciente> pacientes = new List<Paciente>() { 
                new Paciente
                {
                    Id = 1,
                    NombreCompleto = "Carlos Mendoza Torres",
                    Edad = 45,
                    Sexo = Sexo.Masculino,
                    Diagnostico = "Dolor abdominal",
                    Estado = EstadoPaciente.Ingresado,
                    FechaIngreso = new DateTime(2026, 8, 10, 14, 30, 0)
                },
                new Paciente
                {
                    Id = 2,
                    NombreCompleto = "Ana Sofía Rodríguez",
                    Edad = 29,
                    Sexo = Sexo.Femenino,
                    Diagnostico = "Fiebre",
                    Estado = EstadoPaciente.DeAlta,
                    FechaIngreso = new DateTime(2026, 8, 11, 8, 15, 0)
                },
                new Paciente
                {
                    Id = 3,
                    NombreCompleto = "Luis Alberto Gómez",
                    Edad = 67,
                    Sexo = Sexo.Masculino,
                    Diagnostico = "Olla",
                    Estado = EstadoPaciente.DeAlta,
                    FechaIngreso = DateTime.Now
                }
            };
        private int counter = pacientes.Count;


        // Agrega un paciente a la lista y le asigna un Id
        public void AgregarPaciente(Paciente paciente)
        {
            // Garantizar que no haya IDs repetidos.
            // Si el objeto paciente ya trae un Id (>0), lo usamos como propuesta,
            // si no, comenzamos desde el contador interno.
            int proposedId = paciente.Id > 0 ? paciente.Id : counter;

            // Si el Id propuesto ya existe, aumentamos de uno en uno hasta encontrar uno libre
            while (pacientes.Any(p => p.Id == proposedId))
            {
                proposedId++;
            }

            paciente.Id = proposedId;
            pacientes.Add(paciente);

            // Ajustar el contador para futuras asignaciones (evitar reutilizar Ids bajos)
            if (proposedId >= counter)
            {
                counter = proposedId + 1;
            }
        }
        public void EliminarPaciente(Paciente paciente)
        {
            pacientes.Remove(paciente);
        }
        // Devuelve todos los pacientes actuales
        public List<Paciente> ObtenerPacientes()
        {
            return pacientes;
        }
        public List<Paciente> ObtenerPacientePorNombre(string nom)
        {
            return pacientes.Where(p => p.NombreCompleto.Contains(nom)).ToList();
        }
        public void editarPaciente(int id,Paciente patient) {
            // Busca el paciente por su Id y actualiza los campos necesarios
            Paciente pacienteExistente = pacientes.FirstOrDefault(p => p.Id == id);

            if (pacienteExistente != null)
            {
                pacienteExistente.NombreCompleto = patient.NombreCompleto;
                pacienteExistente.Edad = patient.Edad;
                pacienteExistente.Sexo = patient.Sexo;
                pacienteExistente.Diagnostico = patient.Diagnostico;
                pacienteExistente.Estado = patient.Estado;
                pacienteExistente.FechaIngreso = patient.FechaIngreso;


            }


        }

        public List<Paciente> encontrarPacientePorID(int id)
        {
            return pacientes.Where(p => p.Id == id).ToList();
        }
    }
}