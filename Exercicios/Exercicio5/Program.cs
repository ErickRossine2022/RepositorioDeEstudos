using System.Globalization;


namespace Exercicio5
{
    class Program
    {
        static void Main()
        {
            int[] numeracao =
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11

            };

            string[] cardaPio =
            {
                "Cachorro Quente", //0
                "X-Salada", //1
                "X-Tudo", //2
                "X-Bacon", //3
                "Misto-Quente", //4
                "Torrada Simples", //5
                "Coca-Cola", //6
                "Guarana", //7
                "RedBull", //8
                "Agua", //9
                "Cervejinha-Skol" //10
            };

            double[] valor =
            {
                5.00, //0
                12.00, //1
                25.00, //2
                18.00, //3
                8.00, //4
                2.50, //5
                10.00, //6
                8.00, //7
                4.50, //8
                2.50, //9
                5.00 //10
            };

            int[] Key =
            {
                40028922, //0
                55450000, //1
                8922334, //2
                157, //3
                88972, //4
                762902, //5
                190, //6
                192, //7
                9877652, //8
                987100, //9
                555555, //10
            };

            Console.WriteLine("====================== | Bem Vindo(a) Restaurante Blank1ll The Dev | =======================================");
            Console.WriteLine("Deseja Fazer Algum Pedido Mestre?");
            Console.WriteLine("Caso deseja Mostraremos Nosso Menu do Cardapio");
            Console.WriteLine("Caso ocontrario Vaza do Meu restaurante");
            Console.WriteLine("============================================================================================================");
            Console.Write("\nDigite: (Sim/Não): ");
            string opcao = Console.ReadLine();

            if (opcao == "Sim")
            {
                Console.WriteLine("====================== | Cardapio By Blank1ll | =========================");
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"{numeracao[i]}. {cardaPio[i]} Codigo {Key[i]} Valor " + valor[i].ToString("F2", CultureInfo.InvariantCulture) + " reais");
                }
                Console.WriteLine("===========================================================================");

                Console.WriteLine("Digite (Codigo do Item) (Quantidade): ");
                string[] compra = Console.ReadLine().Split(' ');

                int Codigo = int.Parse(compra[0]);
                int Quantidade = int.Parse(compra[1]);

                switch (Codigo)
                {
                    case 40028922:
                        double value = (double)valor[0] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 55450000:
                        double value1 = (double)valor[1] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value1.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 8922334:
                        double value2 = (double)valor[2] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value2.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 157:
                        double value3 = (double)valor[3] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value3.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 88972:
                        double value4 = (double)valor[4] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value4.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 762902:
                        double value5 = (double)valor[5] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value5.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 190:
                        double value6 = (double)valor[6] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value6.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 192:
                        double value7 = (double)valor[7] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value7.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 9877652:
                        double value8 = (double)valor[8] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value8.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 987100:
                        double value9 = (double)valor[9] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value9.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    case 555555:
                        double value10 = (double)valor[10] * Quantidade;
                        Console.WriteLine("o Valor Total a Pagar: " + value10.ToString("F2", CultureInfo.InvariantCulture) + " reais");
                        break;
                    default:
                        Console.WriteLine("Você Digitou o Codigo Invalido e o Programa Encerrou!");
                        return;
                }
            }
            else if (opcao == "Não")
            {
                Console.WriteLine("Você Cancelou o Pedido Volte Sempre");
                return;
            }
            else
            {
                Console.WriteLine("Você cancelou o Pedido sem nem responder a questão Cuzão");
                return;
            }

        }
    }
}