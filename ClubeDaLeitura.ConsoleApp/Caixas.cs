namespace ClubeDaLeitura.ConsoleApp
{
    public class Caixas
    {
        // Etiqueta (max 50 char), Cor, Dias de empréstimo
        public int Id;
        public string Etiqueta;
        public string Cor;
        public int Emprestimo;

        public Caixas(string etiqueta, string cor, int emprestimo)
        {
            Etiqueta = etiqueta;
            Cor = cor;
            Emprestimo = emprestimo;
        }
    }
}
