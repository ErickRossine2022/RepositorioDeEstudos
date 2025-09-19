using System.Globalization;

/*
           while (true)
           {
               Console.WriteLine("Deseja Saber a raiz quadradada de um Número?");
               Console.Write("Digite um Número: ");
               int number = int.Parse(Console.ReadLine());
               double Result = Math.Sqrt(number);
               Console.WriteLine("Resultado: " + Result.ToString("F3", CultureInfo.InvariantCulture));
           }*/


/*
    bool loop = true;
    while (loop)
    {
        Console.WriteLine("Digite uma Seja Para Logar no Sistema: ");
        int password = int.Parse(Console.ReadLine());

        if(password != 2002)
        {
            Console.WriteLine("Senha Invalida!");
        }
        else
        {
            Console.WriteLine("Senha Correta e o Login Feito com Sucesso!");
            loop = false;
        }
    }
*/

/*bool bolean = true;
            while (bolean)
            {
                Console.WriteLine("Digite Valor X: ");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite Valor Y: ");
                int y = int.Parse(Console.ReadLine());
                
                if(x > 0 && y > 0)
                {
                    Console.WriteLine($"Esse {x} e {y} = pertencem a: primeiro");
                }
                else if(x > 0 && y < 0)
                {
                    Console.WriteLine($"Esse {x} e {y} = pertencem a: quarto");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"Esse {x} e {y} = pertencem a: terceiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine($"Esse {x} e {y} = pertencem a: segundo");
                }
                else
                {
                    Console.WriteLine($"Esse {x} e {y} = pertencem a: nulo");
                    bolean = false;
                    Console.WriteLine("Programa Encerrado!");
                }
}*/

namespace Exercicio8
{ 
    class Program
    {
        static void Main()
        {
            bool bolean = true;

            int simasturbo = 0;
            int Gasolina = 0;
            int Disel = 0;
            int Alcol = 0;

            while (bolean)
            {
                Console.WriteLine("=========| Posto de Gasolina SimasTurbo | ================");
                Console.WriteLine($"Contagem SimbasTurbo Clientes a Gasolina {Gasolina}");
                Console.WriteLine($"Contagem SimbasTurbo Clientes a Alcol {Disel}");
                Console.WriteLine($"Contagem SimbasTurbo Clientes a Disel {Alcol}");
                Console.WriteLine("============================================================");


                Console.Write("Qual Você Quer?: ");
                simasturbo = int.Parse(Console.ReadLine());

                if(simasturbo == 1)
                {
                    Gasolina++;
                }
                else if(simasturbo == 2)
                {
                    Disel++;
                }
                else if (simasturbo == 3)
                {
                    Alcol++;
                }
                else
                {
                    Console.WriteLine("Muito Obrigado");
                    bolean = false;
                }
            }
        }
    }
}

