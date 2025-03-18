using System.ComponentModel.Design;

namespace Calculador.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {




            // loop de execução - estrutura de repetição

            // while - enquanto (condição)

            string[] historicooperaçoes = new string [100]; // histórico de operaçoes - aloca espaço na memória (array [x numero de variaveis]
            
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


                string opcao = Console.ReadLine();

                if (opcao == "S")
                {
                    break;
                }

                else if (opcao == "s")
                {
                    break;
                }


                else if (opcao == "5")
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("---------------------------------------------");

                    Console.Write("Digite o número desejado:");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    // for - para
                    // 1 - contador =  variavel de controle
                    // 2 - condição
                    // 3 - mecanismo de incrementação
                    // 1 x 1 = 1
                    // 1 x 2 = 2

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resultadomultiplicacao = numeroTabuada * contador;
                        string linhadaTabuada = numeroTabuada + " x " + contador + " = " + resultadomultiplicacao;
                        // string linhadaTabuada = $"{numeroTabuada} x {contador} = {resultadomultiplicacao}"; // $ interpolaçao de variaveis na string

                        Console.WriteLine(linhadaTabuada);

                    }

                    //MESMA COISA Q
                    // int contador = 1;
                    // while (contador <= 10)
                    //{
                    //contador++
                    //}

                    Console.ReadLine();
                    continue;
                }



                // string = texto (guarda na memória)

                Console.Write("Digite o primeiro número: ");
                string strprimeiroNumero = Console.ReadLine();

                decimal primeiroNumero = Convert.ToDecimal(strprimeiroNumero);


                Console.Write("Digite o segundo número: ");
                string strsegundoNumero = Console.ReadLine();

                decimal segundoNumero = Convert.ToDecimal(strsegundoNumero);

                // numeros decimais

                decimal resultado = 0.0m;


                // estrutura de decisão // se / se não


                    //soma


                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    historicooperaçoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }


                //subtração

                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    historicooperaçoes[contadorHistorico] = $"{primeiroNumero} -{segundoNumero} = {resultado}";
                }

                //multiplicação

                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    historicooperaçoes[contadorHistorico] = $"{primeiroNumero} *{segundoNumero} = {resultado}";
                }

                //divisão

                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.Write("Digite o segundo número novamente: ");

                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }

                    resultado = primeiroNumero / segundoNumero;
                    historicooperaçoes[contadorHistorico] = $"{primeiroNumero} /{segundoNumero} = {resultado}";

                }
                else
                    continue;

                contadorHistorico++;

                    Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2")); // floating points 2 (casas dps da virgula
                Console.WriteLine("---------------------------------------------");


                Console.ReadLine();
                
                    
               

                    

            }

            


        }
    }
}
