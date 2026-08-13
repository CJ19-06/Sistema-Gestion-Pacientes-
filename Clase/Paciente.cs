using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_gestion_de_Pacientes.Entidades
{
    // Representa el sexo del paciente
    public enum Sexo { Masculino, Femenino }

    // Estados válidos para un paciente en el sistema
    public enum EstadoPaciente
    {
        Ingresado,
        EnObservacion,
        DeAlta,
        Hospitalizado
    }
    // Clase que representa a un paciente con sus propiedades principales
    public class Paciente
    {
        public int Id { get; set; }
        
        public int Edad { get; set; }

        public string NombreCompleto { get; set; }

        public Sexo Sexo { get; set; }

        public string Diagnostico { get; set; }

        public EstadoPaciente Estado { get; set; }

        public DateTime FechaIngreso { get; set; }

    }

}