using System.Globalization;

/*
        //Exercicio 6 Concluido
        Console.Write("Digite um Numero (Decimal): ");
        double number = double.Parse(Console.ReadLine());

        if (number >= 0.0 && number <= 25.0)
        {
            Console.WriteLine("seu numero:" + number.ToString("F2", CultureInfo.InvariantCulture) + " Está entre 0.0 e 25.0");
        }
        else if (number > 25.0 && number <= 50.0)
        {
            Console.WriteLine("seu numero:" + number.ToString("F2", CultureInfo.InvariantCulture) + " Está entre 25.0 e 50.0");
        }
        else if (number > 50.0 && number <= 75.0)
        {
            Console.WriteLine("seu numero:" + number.ToString("F2", CultureInfo.InvariantCulture) + " Está entre 50.0 e 75.0");
        }
        else if (number > 75.0 && number <= 100.0)
        {
            Console.WriteLine("seu numero:" + number.ToString("F2", CultureInfo.InvariantCulture) + " Está entre 75.0 e 100.0");
        }
        else
        {
            Console.WriteLine("Você digitou um Numero Decimal acima de 100.0 e o Programa foi Encerrado!");
            return;
        }

        //Exercicio Concluido 7
        Console.Write("Digite um Numero Flutuante X: ");
        double number = double.Parse(Console.ReadLine());

        Console.Write("Digite um Numero Flutuante Y: ");
        double number2 = double.Parse(Console.ReadLine());

        if (number > 0 && number2 > 0)
        {
            Console.WriteLine("Quadrante 1");
        }
        else if (number < 0 && number2 > 0)
        {
            Console.WriteLine("Quadrante 2");
        }
        else if (number < 0 && number2 < 0)
        {
            Console.WriteLine("Quadrante 3");
        }
        else if (number > 0 && number2 < 0)
        {
            Console.WriteLine("Quadrante 4");
        }
        else if (number == 0 && number2 != 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (number != 0 && number2 == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else
        {
            Console.WriteLine("Origem");
        }

*/

namespace Exercicio6
{
    class Program
    {
        static void Main()
        {
            double[] FaixaDeSalario =
            {
                2000.00,
                3000.00,
                4500.00
            };
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("Faixa Salarial do País de Lisarb Calculo de Imposto");
            Console.WriteLine("====================================");
            for (int i = 0; i < FaixaDeSalario.Length; i++)
            {
                Console.WriteLine(FaixaDeSalario[i] + "$ Rombus");
            }
            Console.WriteLine("====================================");
            Console.Write("Quer Calcular Renda? Digite (Sim/Não): ");

            string resposta = Console.ReadLine();

            if (resposta == "Sim")
            {
                Console.Clear();
                Console.Write("Qual é seu Salario Mensal?: ");
                double Salario = double.Parse(Console.ReadLine());

                if (Salario <= FaixaDeSalario[0])
                {
                    Console.WriteLine("Você está esento de Imposto!");
                }
                else if (Salario > FaixaDeSalario[0] && Salario <= FaixaDeSalario[1])
                {
                    double conta = (Salario - 2000.00) * 0.08;
                    Console.WriteLine("Você Deve Pagar: " + conta.ToString("F2", CultureInfo.InvariantCulture) + "$ Rumbos de Imposto de Renda");
                }
                else if (Salario > FaixaDeSalario[1] && Salario <= FaixaDeSalario[2])
                {
                    double conta = (1000.00 * 0.08) + ((Salario - 3000.00) * 0.18);
                    Console.WriteLine("Você Deve Pagar: " + conta.ToString("F2", CultureInfo.InvariantCulture) + "$ Rumbos de Imposto de Renda");
                }
                else
                {
                    double conta = (1000.00 * 0.08) + (1500.00 * 0.18) + ((Salario - 4500.00) * 0.28);
                    Console.WriteLine("Você Deve Pagar: " + conta.ToString("F2", CultureInfo.InvariantCulture) + "$ Rumbos de Imposto de Renda");
                }
            }
            else
            {
                Console.WriteLine("Você Encerrou o Programa!");
                return;
            }

        }
    }
}

