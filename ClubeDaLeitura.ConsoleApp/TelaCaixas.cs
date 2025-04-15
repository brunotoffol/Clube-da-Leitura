using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloAmigos;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class TelaCaixas
    {

        public Caixas[] caixas = new Caixas[100];
        public int contadorCaixas = 0;
        public char ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("1 - Excluir");
            Console.WriteLine("4 - Visualização das Caixas Cadastradas");
            Console.WriteLine("S - Voltar");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Escolha a operação desejada: ");
            char opcaoEscolhida = Convert.ToChar(Console.ReadLine()!);

            return opcaoEscolhida;

        }
        public void CadastrarCaixa()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Cadastrando Caixa...");
            Console.WriteLine("---------------------------------------------");

            string etiqueta;
            do
            {
                Console.Write("Digite um nome para a etiqueta desejada: ");
                etiqueta = Console.ReadLine()!.Trim();

                if (etiqueta.Length > 50)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Não foi possível realizar o cadastro, a etiqueta inserido ultrapassa o limite de caracteres permitido");
                }
            } while (etiqueta.Length > 50);

            #region
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Escolha uma cor da lista abaixo:");
            Console.WriteLine("1 - Vermelho");
            Console.WriteLine("2 - Azul");
            Console.WriteLine("3 - Verde");
            Console.WriteLine("4 - Amarelo");
            Console.WriteLine("5 - Preto");
            #endregion

            string corEscolhida = "";
            bool corValida = false;
            while (!corValida)
            {
                Console.Write("Selecione uma cor para a etiqueta: ");
                string escolha = Console.ReadLine()!.Trim();

                switch (escolha)
                {
                    case "1":
                        corEscolhida = "Vermelho";
                        corValida = true;
                        break;
                    case "2":
                        corEscolhida = "Azul";
                        corValida = true;
                        break;
                    case "3":
                        corEscolhida = "Verde";
                        corValida = true;
                        break;
                    case "4":
                        corEscolhida = "Amarelo";
                        corValida = true;
                        break;
                    case "5":
                        corEscolhida = "Preto";
                        corValida = true;
                        break;
                    default: break;

                }
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Utilizar o tempo padrão de 7 dias para esta caixa? (S/N)");
            string escolhaEmprestimo = Console.ReadLine()!.ToUpper();
            int emprestimoTempo = 7;

            if (escolhaEmprestimo == "N")
            {
                bool emprestimoValido = false;

                while (!emprestimoValido)
                {
                    Console.WriteLine("Digite o tempo de empréstimo desejado para esta etiqueta: ");
                    string emprestimoEscolha = Console.ReadLine()!;

                    if (int.TryParse(emprestimoEscolha, out emprestimoTempo) && emprestimoTempo > 0)
                    {
                        emprestimoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Digite um valor válido!");
                    }
                }
            }

            Caixas novaCaixa = new Caixas(etiqueta, corEscolhida, emprestimoTempo);
            novaCaixa.Id = GeradorIds.GerarIdCaixa();

            caixas[contadorCaixas++] = novaCaixa;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Pressione ENTER para finalizar o cadastro e retornar ao Menu");
            Console.Read();

        }
        public void EditarCaixa()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Editando Caixa...");
            Console.WriteLine("---------------------------------------------");
            
            Console.WriteLine();
            
            VisualizarCaixas(true);

            Console.Write("Digite o ID da caixas que deseja selecionar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o novo nome para a etiqueta da caixa: ");
            string etiqueta = Console.ReadLine()!;

            Console.WriteLine("Selecione uma nova cor para a caixa: ");
            #region
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Escolha uma cor da lista abaixo:");
            Console.WriteLine("1 - Vermelho");
            Console.WriteLine("2 - Azul");
            Console.WriteLine("3 - Verde");
            Console.WriteLine("4 - Amarelo");
            Console.WriteLine("5 - Preto");
            #endregion

            string corEscolhida = "";
            bool corValida = false;
            while (!corValida)
            {
                Console.Write("Selecione uma cor para a etiqueta: ");
                string escolha = Console.ReadLine()!.Trim();

                switch (escolha)
                {
                    case "1":
                        corEscolhida = "Vermelho";
                        corValida = true;
                        break;
                    case "2":
                        corEscolhida = "Azul";
                        corValida = true;
                        break;
                    case "3":
                        corEscolhida = "Verde";
                        corValida = true;
                        break;
                    case "4":
                        corEscolhida = "Amarelo";
                        corValida = true;
                        break;
                    case "5":
                        corEscolhida = "Preto";
                        corValida = true;
                        break;
                    default: break;

                }
            }

            Console.Write("Digite um novo tempo de empréstimo para os itens desta caixa: ");
            int emprestimo = Convert.ToInt32(Console.ReadLine());

            Caixas novaCaixa = new Caixas(etiqueta, corEscolhida, emprestimo);

            bool conseguiuEditar = false;

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null) continue;

                else if (caixas[i].Id == idSelecionado)
                {
                    caixas[i].Etiqueta = novaCaixa.Etiqueta;
                    caixas[i].Cor = novaCaixa.Cor;
                    caixas[i].Emprestimo = novaCaixa.Emprestimo;

                    conseguiuEditar = true;
                }

                if (!conseguiuEditar)
                {
                    Console.WriteLine("Não foi possível editar a caixa. Por favor, tente novamente.");
                }
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Pressione ENTER para retornar ao Menu Principal");

        }
        public void VisualizarCaixas(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("|              Clube do Livro               ");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Visualizando lista de Caixas...");
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("{0, -5} | {1, -15} | {2, -11} | {3, -20}", "Id", "Etiqueta", "Cor", "Tempo de Emprestimo");

                for (int i = 0; i < caixas.Length; i++)
                {
                    Caixas c = caixas[i];

                    if (c == null) continue;

                    Console.WriteLine("{0, -5} | {1, -15} | {2, -11} | {3, -20}", c.Id, c.Etiqueta, c.Cor, c.Emprestimo);
                }
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}


