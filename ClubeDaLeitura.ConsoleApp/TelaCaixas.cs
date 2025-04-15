﻿using System.Runtime.ConstrainedExecution;

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
            Console.Write("Utilizar o tempo padrão de 7 dias para esta caixa? (S/N)");
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

            Console.WriteLine($"Tempo de empréstimo definido: {emprestimoTempo} dias");
        }

        public void VisualizarCaixas
    }
}


