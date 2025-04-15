using System.Text.RegularExpressions;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class TelaAmigos
    {
        public Amigos[] amigos = new Amigos[100];
        public int contadorAmigos = 0;
        public char ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("3 - Excluir");
            Console.WriteLine("4 - Visualização dos Amigos Cadastrados");
            Console.WriteLine("5 - Visualização dos Empréstimos");
            Console.WriteLine("S - Voltar");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Escolha a operação desejada: ");
            char opcaoEscolhida = Convert.ToChar(Console.ReadLine()!);

            return opcaoEscolhida;


        }
        public void CadastrarAmigo()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Cadastrando Amigo...");
            Console.WriteLine("---------------------------------------------");            

            string nome;
            do
            {
                Console.Write("Digite o nome do amigo: ");
                nome = Console.ReadLine()!.Trim();

                if (nome.Length < 3 || nome.Length > 100)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Não foi possível realizar o castro, o nome inserido é muito curto ou longo");
                }
            } while (nome.Length < 3 || nome.Length > 100);

            string nomeResponsavel;
            do
            {
                Console.Write("Digite o nome do responsável: ");
                nomeResponsavel = Console.ReadLine()!.Trim();
                if (nome.Length < 3 || nome.Length > 100)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Não foi possível realizar o castro, o nome inserido é muito curto ou longo");
                }
            } while (nome.Length < 3 || nome.Length > 100);

            string telefone;
            Regex regexTelefone = new Regex(@"^\(?\d{2}\)?\s?\d{4,5}-?\d{4}$");
            do
            {
                Console.Write("Digite o telefone do amigo, formato (XX) XXXX-XXXX: ");
                telefone = Console.ReadLine()!.Trim();

                if (!regexTelefone.IsMatch(telefone))
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Telefone inválido. Tente novamente no formato correto.");
                }

            } while (!regexTelefone.IsMatch(telefone));

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Pressione ENTER para finalizar o cadastro e retornar ao Menu");
            Console.Read();

            Amigos novoAmigo = new Amigos(nome, nomeResponsavel, telefone);
            amigos[contadorAmigos++] = novoAmigo;

        }
        public void EditarAmigo()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Editando Cadastro do Amigo...");
            Console.WriteLine("---------------------------------------------");

            VisualizarAmigos(false);

            Console.WriteLine("---------------------------------------------");
            Console.Write("Digite o ID do amigo que deseja selecionar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o novo nome: ");
            string nome = Console.ReadLine()!.Trim();

            Console.Write("Digite o novo nome do responsável: ");
            string nomeResponsavel = Console.ReadLine()!.Trim();

            Console.Write("Digite o novo telefone para o amigo: ");
            string telefone = Console.ReadLine()!.Trim();

            Amigos novoAmigo = new Amigos(nome, nomeResponsavel, telefone);

            bool conseguiuEditar = false;

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null) continue;

                else if (amigos[i].Id == idSelecionado)
                {
                    amigos[i].Nome = novoAmigo.Nome;
                    amigos[i].NomeResponsavel = novoAmigo.NomeResponsavel;
                    amigos[i].Telefone = novoAmigo.Telefone;

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
            Console.Read();
        }
        public void ExcluirAmigo()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Excluindo Cadastro do Amigo...");
            Console.WriteLine("---------------------------------------------");

            VisualizarAmigos(false);

            Console.WriteLine("---------------------------------------------");
            Console.Write("Digite o ID do amigo que deseja selecionar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = false;

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null) continue;

                else if (amigos[i].Id == idSelecionado)
                {
                    amigos[i] = null!;
                    conseguiuExcluir |= true;
                }


            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Cadastro excluído com sucesso!");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Pressione ENTER para finalizar o cadastro e retornar ao Menu");
            Console.Read();
        }
        public void VisualizarAmigos(bool exibirTitulo)
        {
            if (exibirTitulo)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("|              Clube do Livro               ");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Visualizando lista de Amigos...");
                Console.WriteLine("---------------------------------------------");                
            }
            Console.WriteLine("{0, -5} | {1, -15} | {2, -11} | {3, -20}","Id", "Nome", "Nome Responsável", "Telefone");

            for (int i = 0; i < amigos.Length; i++)
            {
                Amigos a = amigos[i];
                
                if (a == null) continue;
                
                Console.WriteLine("{0, -5} | {1, -15} | {2, -11} | {3, -20}",a.Id, a.Nome, a.NomeResponsavel, a.Telefone);

            }
        }
    }
}    




