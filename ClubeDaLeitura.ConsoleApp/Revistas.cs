namespace ClubeDaLeitura.ConsoleApp
{
    public class Revistas
    {
        public int Id;
        public string Titulo;
        public int NumeroEdicao;
        public int AnoPublicacao;        

        public Revistas(string titulo, int numeroEdicao, int anoPublicacao)
        {            
            Titulo = titulo;
            NumeroEdicao = numeroEdicao;
            AnoPublicacao = anoPublicacao;
        }
    }
}
