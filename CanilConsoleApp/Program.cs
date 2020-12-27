using System;
using System.Collections.Generic;
using CanilConsoleApp.Colecoes;

namespace CanilConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfiguracaoDb.Usuario = "mongo";
            ConfiguracaoDb.Senha = "!123Senha";
            ConfiguracaoDb.Host = "localhost";
            ConfiguracaoDb.Porta = 27017;
            ConfiguracaoDb.Banco = "canil";
            ConfiguracaoDb.BancoAutenticancao = "admin";

            var fulano = new Cliente(
                "Fulano",
                "Masculino",
                "12345678",
                "01234567890",
                new DateTime(2000, 1, 1),
                "11999999999",
                "Rua sem saida",
                "123", 
                "JD Algum lugar",
                "São Paulo",
                "SP"
            );

            var db = new SuporteDb();
            db.RepositorioDeClientes.InsertOne(fulano);

            var medicamentosParaORex = new List<Medicamento>
            {
                new Medicamento("Dipirona", "ciclano"),
                new Medicamento("Coroquina", "ciclano"),
                new Medicamento("Acebrofilina", "ciclano"),
            };

            var rex = new Paciente("Rex", new DateTime(2005, 1, 1), "Cahorro", fulano.Id, medicamentosParaORex);

            db.RepositorioDePacientes.InsertOne(rex);


            Console.WriteLine("Terminou o exemplo");
            Console.ReadKey();
        }
    }
}