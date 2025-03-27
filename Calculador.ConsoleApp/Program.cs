using System.ComponentModel.Design;

namespace Calculador.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string[] historicooperaçoes = new string [100];
            
            int contadorHistorico = 0;
            

            while (true)
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


                Console.WriteLine("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "S")
                    break;

                else if (opcao == "s")
                    break;

                else if (opcao == "5")
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("---------------------------------------------");

                    Console.Write("Digite o número desejado:");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                        Console.WriteLine($"{numeroTabuada}x{contador}={numeroTabuada * contador}");


                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("---------------------------------------------");

                    for (int contador = 0; contador < contadorHistorico; contador++)
                        Console.WriteLine(historicooperaçoes[contador]);


                    Console.ReadLine();
                    continue;

                }

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

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("---------------------------------------------");


                Console.ReadLine();
            }




        }
        

    }
}
