

/* 

    Minha Versão do Exercicio Novo Do Curso


while (true)
{
    Console.Write("Digite três Números: ");
    string[] numeros = Console.ReadLine().Split(' ');
    int number = int.Parse(numeros[0]);
    int number2 = int.Parse(numeros[1]);
    int number3 = int.Parse(numeros[2]);

    if (number > number2 && number > number3)
    {
        Console.WriteLine($"o Numero Maior é {number} porque {number2} e {number3} são menores");
    }
    else if (number < number2 && number2 > number3)
    {
        Console.WriteLine($"o Numero Maior é {number2} porque {number} e {number3} são menores");
    }
    else
    {
        Console.WriteLine($"o Numero Maior é {number3} porque {number} e {number2} são menores");
    }
}


*/


/*

    Versão do Professor mais o menos

while (true)
{
    Console.Write("Digite três Números: ");
    int number = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());
    int number3 = int.Parse(Console.ReadLine());

    if (number > number2 && number > number3)
    {
        Console.WriteLine($"o Numero Maior é {number} porque {number2} e {number3} são menores");
    }
    else if (number2 > number3)
    {
        Console.WriteLine($"o Numero Maior é {number2} porque {number} e {number3} são menores");
    }
    else
    {
        Console.WriteLine($"o Numero Maior é {number3} porque {number} e {number2} são menores");
    }
}
*/

namespace Exercicio7
{
    class Program
    {
        static void Main()
        {
            //Exemplo de Como Transformar o Calculo em uma Função
            Console.Write("Digite três Números: ");
            string[] digitacao = Console.ReadLine().Split(' ');

            int number = int.Parse(digitacao[0]);
            int number2 = int.Parse(digitacao[1]);
            int number3 = int.Parse(digitacao[2]);

            int Resultado = Maior(number, number2, number3);

            Console.WriteLine("o Número maior é " + Resultado);
        }

        //Exemplo de Como criar uma Nova Função
        //a Função criada é para Descobrir o Valor maior de um numero
        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}


