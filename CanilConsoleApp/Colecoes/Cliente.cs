using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CanilConsoleApp.Colecoes
{
    public class Cliente
    {
        public Cliente(string nome, string sexo, string rg, string cpf, DateTime dataNascimento, string celular, string endereço, string numeroCasa, string bairro, string municipio, string uf)
        {
            Nome = nome;
            Sexo = sexo;
            RG = rg;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Celular = celular;
            Endereço = endereço;
            NumeroCasa = numeroCasa;
            Bairro = bairro;
            Municipio = municipio;
            UF = uf;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public string WhatsApp { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Observação { get; set; }
        public string Localização { get; set; }
        public string Endereço { get; set; }
        public string NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        
        
    }
}