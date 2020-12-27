using System;
using System.Collections.Generic;

namespace CanilConsoleApp
{
    public class Paciente
    {
        public Paciente(string nome, DateTime dataNascimento, string tipoAnimal, string idDoCliente, List<Medicamento> medicamentos)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.TipoAnimal = tipoAnimal;
            this.IdDoCliente = idDoCliente;
            this.Medicamentos = medicamentos;
        }

        public List<Medicamento> Medicamentos { get; set; }
        public string IdDoCliente { get; set; }
        public string TipoAnimal { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
    }
}