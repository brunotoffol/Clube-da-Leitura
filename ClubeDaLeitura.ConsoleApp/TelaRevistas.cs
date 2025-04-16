using ClubeDaLeitura.ConsoleApp.ModuloAmigos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class TelaRevistas
    {
        public Revistas[] revistas = new Revistas[100];
        public int contadorRevistas = 0;
        public char ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("3 - Excluir");
            Console.WriteLine("4 - Visualização das Revistas Cadastradas");  
            Console.WriteLine("S - Voltar");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Escolha a operação desejada: ");
            char opcaoEscolhida = Convert.ToChar(Console.ReadLine()!);

            return opcaoEscolhida;
        }
        public void CadastrarRevista()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Cadastrando Revista...");
            Console.WriteLine("---------------------------------------------");

            string titulo;
            do
            {
                Console.Write("Digite um título para a revista: ");
                titulo = Console.ReadLine()!.Trim();

                if (titulo.Length < 3 || titulo.Length > 100)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Não foi possível realizar o cadastro, o nome inserido é muito curto ou longo");
                }
            } while (titulo.Length < 3 || titulo.Length > 100);

            Console.Write("Digite o número de edição da revista: ");
            int numeroEdicao = Convert.ToInt32((Console.ReadLine()!).Trim());

            Console.Write("Digite o número de edição da revista: ");
            int anoPublicacao = Convert.ToInt32((Console.ReadLine()!).Trim());

            Revistas novaRevista = new Revistas(titulo, numeroEdicao, anoPublicacao);
            revistas[contadorRevistas++] = novaRevista;
        }
        public void EditarRevista()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Editando Cadastro da Revista...");
            Console.WriteLine("---------------------------------------------");

            VisualizarRevista(false);

            Console.WriteLine("---------------------------------------------");
            Console.Write("Digite o ID do amigo que deseja selecionar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o novo titulo: ");
            string titulo = Console.ReadLine()!.Trim();
            
            Console.Write("Digite o novo número de edição: ");
            int numeroEdicao = Convert.ToInt32(Console.ReadLine()!.Trim());

            Console.Write("Digite o novo ano de publicação: ");
            int anoPublicacao = Convert.ToInt32(Console.ReadLine()!.Trim());

            Revistas novaRevista = new Revistas(titulo, numeroEdicao, anoPublicacao);

            bool conseguiuEditar = false;

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null) continue;

                else if (revistas[i].Id == idSelecionado)
                {
                    revistas[i].Titulo = novaRevista.Titulo;
                    revistas[i].NumeroEdicao = novaRevista.NumeroEdicao;
                    revistas[i].AnoPublicacao = novaRevista.AnoPublicacao;

                    conseguiuEditar = true;
                }
            }

            if (!conseguiuEditar)
            {
                Console.WriteLine("Não foi possível editar o amigo selecionado");
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Cadastro editado com sucesso!");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Pressione ENTER para finalizar o cadastro e retornar ao Menu");
            Console.ReadKey();
        }
        public void ExcluirRevista()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Excluindo Cadastro de Revista...");
            Console.WriteLine("---------------------------------------------");

            VisualizarRevista(false);
            Console.WriteLine("---------------------------------------------");
            Console.Write("Digite o ID do amigo que deseja selecionar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = false;

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null) continue;

                else if (revistas[i].Id == idSelecionado)
                {
                    revistas[i] = null!;
                    conseguiuExcluir |= true;
                }


            }
        }
        public void VisualizarRevista(bool exibirTitulo)
        {
            if (exibirTitulo)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("|              Clube do Livro               ");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Visualizando lista de Revistas...");
                Console.WriteLine("---------------------------------------------");
            }
            Console.WriteLine("{0, -5} | {1, -15} | {2, -11} | {3, -20}", "Id", "Titulo", "Número Edição", "Ano de Publicação");

            for (int i = 0; i < revistas.Length; i++)
            {
                Revistas r = revistas[i];

                if (r == null) continue;

                Console.WriteLine("{0, -5} | {1, -15} | {2, -11} | {3, -20}", r.Id, r.Titulo, r.NumeroEdicao, r.AnoPublicacao);
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadKey();
        }
     }
}

