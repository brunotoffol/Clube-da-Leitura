using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloAmigos;
using System.Security.Cryptography.X509Certificates;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            TelaAmigos telaAmigos = new TelaAmigos();
            TelaCaixas telaCaixas = new TelaCaixas();

            while (true)
            {
                char opcaoPrincipal = telaPrincipal.ApresentarMenuPrincipal();

                if (opcaoPrincipal == '1')
                {
                    char opcaoEscolhida = telaAmigos.ApresentarMenu();

                    switch (opcaoEscolhida)
                    {
                        case '1': telaAmigos.CadastrarAmigo(); break;

                        case '2': telaAmigos.EditarAmigo(); break;
                        
                        case '3': telaAmigos.ExcluirAmigo(); break;

                        case '4': telaAmigos.VisualizarAmigos(true); break;

                        default: break;
                    }

                    Console.ReadLine();

                }

                if (opcaoPrincipal == '2')
                {
                    char opcaoEscolhida = telaCaixas.ApresentarMenu();

                    switch (opcaoEscolhida)
                    {
                        case '1': telaCaixas.CadastrarCaixa(); break;

                        case '4': telaCaixas.VisualizarCaixas(true); break;

                        default: break;
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}
