using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class TelaPrincipal
    {
        public char ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|              Clube do Livro               ");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Cadastro de Amigos");
            Console.WriteLine("2 - ");
            Console.WriteLine("S - Sair");

            Console.WriteLine("--------------------------------------------");
            Console.Write("Escolha uma das opções: ");

            char opcaoEscolhida = Console.ReadLine()!.Trim()[0];

            return opcaoEscolhida;
        }

    }
}
