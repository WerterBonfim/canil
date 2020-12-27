using System;
using CanilConsoleApp.Colecoes;
using MongoDB.Driver;

namespace CanilConsoleApp
{
    public class SuporteDb
    {
        private IMongoClient Cliente { get; }
        private IMongoDatabase Banco { get; set; }

        public IMongoCollection<Cliente> RepositorioDeClientes { get; set; }
        public IMongoCollection<Paciente> RepositorioDePacientes { get; set; }

        public SuporteDb()
        {
            Console.WriteLine("Iniciando a configuração com o MongoDB");
            Cliente = new MongoClient(MontarStringDeConexao());
            DefinirBanco("canil");
            MontarColecoes();
        }

        private void MontarColecoes()
        {
            RepositorioDeClientes = DefinirColecao<Cliente>("clientes");
            RepositorioDePacientes = DefinirColecao<Paciente>("pacientes");
        }

        private SuporteDb DefinirBanco(string nome)
        {
            Banco = Cliente.GetDatabase(nome);
            return this;
        }

        protected IMongoCollection<T> DefinirColecao<T>(string nome)
        {
            var colecao = Banco.GetCollection<T>(nome);
            return colecao;
        }

        private string MontarStringDeConexao()
        {
            //mongodb://mongo:!123Senha@localhost:27017/admin
            var stringDeConexao =
                $"mongodb://{ConfiguracaoDb.Usuario}:" +
                $"{ConfiguracaoDb.Senha}@" +
                $"{ConfiguracaoDb.Host}:" +
                $"{ConfiguracaoDb.Porta}/" +
                $"{ConfiguracaoDb.BancoAutenticancao}";

            return stringDeConexao;
        }

    }
}