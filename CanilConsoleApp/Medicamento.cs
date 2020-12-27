namespace CanilConsoleApp
{
    public class Medicamento
    {
        public string Medico { get; set; }
        public string Nome { get; set; }
        
        public Medicamento(string nome, string quemReceitou)
        {
            this.Nome = nome;
            this.Medico = quemReceitou;
        }

        
    }
}