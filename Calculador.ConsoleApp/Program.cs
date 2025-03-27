using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Calculador.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {


            string[] historicooperaçoes = new string[100];

            int contadorHistorico = 0;


            while (true)
            {

                string opcao = ExibirMenu();



                if (OpcaoSairFoiEscolhida(opcao))
                    break;

                else if (OpcaoTabuadaFoiEscolhida(opcao))
                    ExibirTabuada();


                else if (OpcaoHistoricoFoiEscolhida(opcao))
                    ExibirHistocioOperacoes(contadorHistorico, historicooperaçoes);

                else if (OpcaoHistoricoFoiEscolhida(opcao))
                    ExibirHistocioOperacoes(contadorHistorico, historicooperaçoes);

                else
                {
                    decimal resultado = RealiazarCalculo(opcao, contadorHistorico, historicooperaçoes);

                    ExibirResultado(resultado);

                }


                
            }




        }


             static string ExibirMenu()
             {
                 Console.Clear();
                 Console.WriteLine("---------------------------------------------");
                 Console.WriteLine("Calculadora Tabajara 2025");
                 Console.WriteLine("---------------------------------------------");
             
                 Console.WriteLine("1 - Somar");
                 Console.WriteLine("2 - Subtrair");
                 Console.WriteLine("3 - Multiplicação");
                 Console.WriteLine("4 - Divisão");
                 Console.WriteLine("5 - Tabuada");
                 Console.WriteLine("6 - Histórico de Operações");
                 Console.WriteLine("S - Sair");
                 Console.WriteLine("----------------------------------------------");


                  Console.Write("Escolha uma opção: ");
                  string opcao = Console.ReadLine();

                  return opcao;
             }
        static bool OpcaoSairFoiEscolhida(string opcao)
        {
            bool OpcaoSairFoiEscolhida = opcao == "5";
            return OpcaoSairFoiEscolhida;
        }

        static bool OpcaoTabuadaFoiEscolhida(string opcao)
        {
            bool opcaoTabuadaFoiEscolhida = opcao == "5";
            return opcaoTabuadaFoiEscolhida;
        }

        static void ExibirTabuada()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Tabuada");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite o número desejado:");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
                Console.WriteLine($"{numeroTabuada}x{contador}={numeroTabuada * contador}");


            Console.ReadLine();
        }

        static bool OpcaoHistoricoFoiEscolhida(string opcao)
        {
            return opcao == "6";
        }

        static void ExibirHistocioOperacoes(int contadorHistorico, string[] historicooperaçoes)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Histórico de Operações");
            Console.WriteLine("---------------------------------------------");

            for (int contador = 0; contador < contadorHistorico; contador++)
                Console.WriteLine(historicooperaçoes[contador]);


            Console.ReadLine();
        }

        static decimal RealiazarCalculo(string opcao, int contadorHistorico, string[]historicooperaçoes)
        {
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite o primeiro número: ");

            string strPrimeiroNumero = Console.ReadLine();

            decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);

            Console.Write("Digite o segundo número: ");

            string strSegundoNumero = Console.ReadLine();

            decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

            decimal resultado = 0.0m;

            if (opcao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
            }


            else if (opcao == "2")
            {
                resultado = primeiroNumero - segundoNumero;
                historicooperaçoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            }

            else if (opcao == "3")
            {
                resultado = primeiroNumero * segundoNumero;
                historicooperaçoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
            }

            else

            {
                while (segundoNumero == 0)
                {
                    Console.WriteLine("Não é possivel dividir por 0");
                    Console.Write("Digite o segundo número novamente: ");
                    segundoNumero = Convert.ToDecimal(Console.ReadLine());
                }

                resultado = primeiroNumero / segundoNumero;
                historicooperaçoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            }
            contadorHistorico++;
            
            return resultado;
        }
        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Resultado: " + resultado.ToString("F2"));
            Console.WriteLine("---------------------------------------------");
        }
    }
}
