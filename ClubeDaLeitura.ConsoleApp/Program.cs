using System.Security.Cryptography.X509Certificates;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            TelaAmigos telaAmigos = new TelaAmigos();


            while (true)
            {
                char opcaoPrincipal = telaPrincipal.ApresentarMenuPrincipal();

                if (opcaoPrincipal == '1')
                {
                    char opcaoEscolhida = telaAmigos.ApresentarMenu();

                    switch (opcaoEscolhida)
                    {
                        case '1': telaAmigos.CadastrarAmigo(); break;

                        default: break;
                    }

                    Console.ReadLine();

                }
            }
        }
    }
}
