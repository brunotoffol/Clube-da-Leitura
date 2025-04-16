namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class Revistas
    {
        public int Id;
        public string Titulo;
        public string Status;
        public int NumeroEdicao;
        public int AnoPublicacao;        

        public Revistas(string titulo, string status, int numeroEdicao, int anoPublicacao)
        {            
            Titulo = titulo;
            Status = status;
            NumeroEdicao = numeroEdicao;
            AnoPublicacao = anoPublicacao;
        }
    }
}
