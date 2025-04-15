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
            Console.WriteLine("1 - Excluir");
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
            Console.WriteLine();

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

            Console.WriteLine("---------------------------------------------");
            Console.Write("Pressione ENTER para finalizar o cadastro e retornar ao Menu");
            Console.Read();

            Amigos novoAmigo = new Amigos(nome, nomeResponsavel, telefone);
            amigos[contadorAmigos++] = novoAmigo;

        }
        public void EditarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Editando Amigo...");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }
        public void VisualizarAmigos(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("|              Clube do Livro               ");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Visualizando lista de Amigos...");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();
            }
            Console.WriteLine("{0, -15} | {1, -11} | {2, -20}", "Nome", "Nome Responsável", "Telefone");

            for (int i = 0; i < amigos.Length; i++)
            {
                Amigos a = amigos[i];
                
                if (a == null) continue;
                
                Console.WriteLine("{0, -15} | {1, -11} | {2, -20}", a.Nome, a.NomeResponsavel, a.Telefone);

            }
        }
    }
}    




