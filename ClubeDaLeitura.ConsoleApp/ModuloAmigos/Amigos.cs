namespace ClubeDaLeitura.ConsoleApp.ModuloAmigos
{
    public class Amigos
    {
        public int Id;
        public string Nome;
        public string NomeResponsavel;
        public string Telefone;

        public Amigos(string nome, string nomeResponsavel, string telefone)
        {
            Nome = nome;
            NomeResponsavel = nomeResponsavel;
            Telefone = telefone;
        }
    }
}
