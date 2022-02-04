using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcao;

            do
            {
                Console.WriteLine("Calculadora Top 1.6");
                Console.WriteLine("Escolha Opção");
                Console.WriteLine("Digite 1 - para somar \nDigite 2 - para subtrair\nDigite 3 - multiplicar \nDigite 4 - para dividir\nDigite 0 - para sair");
                //recebe valor opcao
                opcao = Console.ReadLine();

                //valida menu
                while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "0")
                {
                    Console.WriteLine("Por favor, digite um número válido!");

                    Console.WriteLine("Calculadora Top 1.6");
                    Console.WriteLine("Digite 1 - para somar \nDigite 2 - para subtrair\nDigite 3 - multiplicar \nDigite 4 - para dividir\nDigite 0 - para sair");
                    opcao = Console.ReadLine();
                }

                //encerra o debug 
                if (opcao == "0")
                {
                    Environment.Exit(0);
                }


                Console.WriteLine("Digite os números");

                //recebe o primeiro numero
                Console.Write("Digite o primeiro número: ");
                string strPrimeiroNumero = Console.ReadLine();

                //recebe o segundo numero
                Console.Write("Digite o segundo número: ");
                string strSegundoNumero = Console.ReadLine();


                double primeiroNumero = Convert.ToDouble(strPrimeiroNumero);
                double segundoNumero = Convert.ToDouble(strSegundoNumero);
                double resultadoOperacao = 0;

                //estrutura condicional do menu opcao

                if (opcao == "1")
                {
                    resultadoOperacao = primeiroNumero + segundoNumero;
                }
                if (opcao == "2")
                {
                    resultadoOperacao = primeiroNumero - segundoNumero;
                }
                if (opcao == "3")
                {
                    resultadoOperacao = primeiroNumero * segundoNumero;
                }
                if (opcao == "4")
                {
                    if (primeiroNumero == 0 || segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível realizar divisão por 0");
                    }
                    resultadoOperacao = primeiroNumero / segundoNumero;
                }

                Console.WriteLine("Resultado: " + resultadoOperacao);

            }
            while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4");

        }

    }
}
