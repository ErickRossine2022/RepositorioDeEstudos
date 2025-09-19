using System.Globalization;


/*
        Exercicio 1 o Mais Facil

        Console.Clear();
        int number1 = 10;
        int number2 = 30;
        int result = number1 + number2;

        Console.WriteLine($"a Soma de 10 + 30 = {result}");


        int number3 = -30;
        int number4 = 10;
        int result2 = number3 + number4;
        Console.WriteLine($"o Resultado de -30 + 10 = {result2}");

        int number5 = 0;
        int number6 = 0;
        int result3 = number5 + number6;
        Console.WriteLine($"o Resultado e number5 + number6 = {result3}");
            


          Versão 1 da Explicação do Exercicio


    Declarar variavel double Sem valor = R,  sem Valor = A, pi

    pi é a referencia do Circulo ae no R a pessoa digita o quanto a pessoa que medir
    apos a pessoa digite vai pegar por exemplo quero medir 2.0 do circulo doido ele vai la pega esse numero e faz
    2.0 x 2.0 = 4.0;

    ae ele vai pegar o 2.0 que no caso foi levado ao quadrado multyplicado ele por ele mesmo
    e depois pegar a referencia que o pi e multiplicar ele pelo o resultado do 2.0 ao quadrado que foi 4.0 

    3.14159 x 4.0 = 12.5664;

    Caso se o contralador de casa decimais esteja configurado para mostrar 4 casas decimais o F4



                Versão 2 da Explicação

    - Declarar as variáveis: R (raio), A (área) e pi = 3.14159

    - O valor de pi é uma constante que representa a proporção do círculo

    - O usuário digita o valor do raio (ex: 2.0)

    - O programa faz: 2.0 * 2.0 = 4.0 → isso é o raio ao quadrado

    - Depois faz: 3.14159 * 4.0 = 12.56636 → isso é a área

    - Por fim, o programa imprime o resultado com 4 casas decimais: 12.5664

    - Isso é feito com ToString("F4", ...) que controla a quantidade de casas após a vírgula
           


                Simulação do raio ao quadrado


    double number7 = 8.0;
    double number8 = 8.0;

    double result4 = number7 * number8;

    Console.WriteLine($"o Resultado é: " + result4.ToString("F1", CultureInfo.InvariantCulture));

    double aoQuadrado = 3.14159 * 64.0;

    Console.WriteLine($"o Resultado de 3.14159 x 64.0 = " + aoQuadrado.ToString("F10", CultureInfo.InvariantCulture));

            
            Exercicio 2 do Curso mais dificil pramim
                
            
    double R, A, pi = 3.14159;

    R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    A = pi * R * R;

    Console.WriteLine($"A = {A.ToString("F4", CultureInfo.InvariantCulture)}"); 



                Exercicio 3 - Dificil mais consiguir Concluir

            Minha Versão


    Console.Clear();
    //Perguntar o Primeiro Numero Inteiro
    Console.Write("Digite um Valor Inteiro: ");

    //Ler o String como Numeró Inteiro 
    int A = int.Parse(Console.ReadLine());
    //Mostrar o Primeiro Numeró Inteiro Digitado
    Console.WriteLine($"o Primeiro Numero Inteiro é : {A}");
    //Perguntar o Segundo Numero Inteiro
    Console.Write("Digite o Segundo Numero Inteiro: ");
    //Ler o Segundo String como Numeró Inteiro também
    int B = int.Parse(Console.ReadLine());
    //Multyplicar A x B = [Resultado!]
    int Result = A * B;

    Console.WriteLine($"o Resultado de A X B = {Result}");
    int C = 32;
    int D = 2;

    int Result2 = C * D;

    Console.WriteLine($"o Resultado de C X D = {Result2}");

    int Result3 = Result - Result2;

    Console.WriteLine($"o Resultado de A x B Menos o Resultado de C x D = {Result3}");

            

    Versão do Chat GPT


    Console.Clear();

    // Ler A
    Console.Write("Digite o Primeiro Valor Inteiro: ");
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine($"O Primeiro Número Inteiro é: {A}");

    // Ler B
    Console.Write("Digite o Segundo Valor Inteiro: ");
    int B = int.Parse(Console.ReadLine());
    Console.WriteLine($"O Segundo Número Inteiro é: {B}");

    // Ler C
    Console.Write("Digite o Terceiro Valor Inteiro: ");
    int C = int.Parse(Console.ReadLine());
    Console.WriteLine($"O Terceiro Número Inteiro é: {C}");

   // Ler D
   Console.Write("Digite o Quarto Valor Inteiro: ");
   int D = int.Parse(Console.ReadLine());
   Console.WriteLine($"O Quarto Número Inteiro é: {D}");

   // Calcular produtos
   int prodAB = A * B;
   int prodCD = C * D;

   // Mostrar produtos
   Console.WriteLine($"O Resultado de A x B = {prodAB}");
   Console.WriteLine($"O Resultado de C x D = {prodCD}");

   // Calcular diferença
   int diferenca = prodAB - prodCD;

   // Mostrar diferença

   Console.WriteLine($"O Resultado de A x B menos o Resultado de C x D = {diferenca}");

            Exercicios 4 Modulo 3 C# Facil

    Console.WriteLine("Digite seu nome: ");
    string name = Console.ReadLine();


    Console.WriteLine("Quantas horas por dia você trabalha?: ");
    int hours = int.Parse(Console.ReadLine());

    Console.WriteLine("Quanto Ganha por hora trabalhada: ");
    double service = double.Parse(Console.ReadLine());

    double result = (double)service * hours;
    Console.WriteLine("o Usuario ganha: " + result.ToString("F2"), CultureInfo.InvariantCulture + $"Reais a cada {hours} por dia");


            

    Console.Clear();
    Console.Write("Digite o numero do Funcionario que você quer checar: ");
    nt numberfun = int.Parse(Console.ReadLine());

    Console.Write("Quantas Horas por més o Funcionario Trabalha: ");
    int numberHors = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o Valor que o Funcionario ganha por hora trabalhada: ");
    double valor = double.Parse(Console.ReadLine());

    double result = (double)numberHors * valor;

    Console.WriteLine($"Digite o Funcionario {numberfun} trabalha tipo {numberHors} por mês e cada hora trabalhada no dia a dia");
    Console.WriteLine("Recebe no més: " + result.ToString("F2",CultureInfo.InvariantCulture) + " de reais por mês");

*/



namespace Exercicios3
{
    class Programo
    {
        static void Main()
        {
            Console.Clear();
            string[] Brinquedos =
            {
                "Boneca",
                "Boneco",
                "Carrinho",
                "Bolinha de Gude",
                "Bate Bate",
                "Piaõ",
                "Bola de futebool"
            };

            int[] Quantidade =
            {
                15,
                20,
                8,
                300,
                2,
                9,
                30
            };

            double[] Valor =
            {
                20.00,
                20.00,
                30.00,
                0.50,
                2.50,
                1.50,
                50,0

            };


            Console.WriteLine("============================= | Opçẽoes que Você Pode Escolher =========================================");
            Console.WriteLine("1. Escolher Quantas vezes que você vai poder Esoclher o Produto pra comprar");
            Console.WriteLine("2. Encerrar o Programa");
            Console.WriteLine("=========================================================================================================");
            Console.Write("Digite o Numero da Opcão a cima: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite a Quantidade de vezes você vai poder comprar algum produto: ");
                    int VezesCompra = int.Parse(Console.ReadLine());
                    bool LigarLoja = true;
                    while (LigarLoja)
                    {
                        Console.WriteLine("============= | Briquedos da Lojinha do Edu | ==========================");
                        for (int v = 0; v < 7; v++)
                        {
                            Console.WriteLine($"Brinquedo {Brinquedos[v]} Quantidade no Stock: {Quantidade[v]} Valor " + Valor[v].ToString("F2", CultureInfo.InvariantCulture) + " Centavos/Reais");
                        }
                        Console.WriteLine("========================================================================");

                        Console.WriteLine("Digite [ NOME ITEM ] [ QUANTIDADE ]");

                        string[] compra = Console.ReadLine().Split(' ');

                        string ItemComprado = compra[0];
                        int ItemQuantidade = int.Parse(compra[1]);
                        bool ItemEncontrado = false;
                        for (int i = 0; i < Brinquedos.Length; i++)
                        {
                            //Verificar se o usuario digitou o Nome correto do Item caso não digitar da erro
                            if (ItemComprado.Equals(Brinquedos[i], StringComparison.OrdinalIgnoreCase))
                            {
                                int result = (int)Valor[i] * ItemQuantidade;
                                Console.WriteLine($"Valor total a pagar: " + result.ToString("F2", CultureInfo.InvariantCulture) + " Reais");
                                VezesCompra--;
                                ItemEncontrado = true;
                                break;
                            }
                        }
                        if (!ItemEncontrado)
                        {
                            Console.WriteLine("Item não encontrado no nossos Dados!");
                        }
                        if (VezesCompra == 0)
                        {
                            Console.Clear();
                            LigarLoja = false;
                            Console.WriteLine("Você atigiu o limite de compras");
                        }
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Você encerrou o Programa");
                    return;
                    break;

                default:
                    Console.WriteLine("Opçâo Invalida!");
                    break;
            }
        }
    }
}
