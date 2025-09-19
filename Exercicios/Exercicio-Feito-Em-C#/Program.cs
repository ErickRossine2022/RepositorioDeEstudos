
class Program
{
    static void Main()
    {
        Console.Clear();

        bool ligarloop = true;

        while (ligarloop)
        {
            //Perguntar como é o nome do usuario
            Console.Write("Digite seu nome: ");
            //Ler o Nome do Usuario
            string nome = Console.ReadLine();
            //Perguntar qual é a idade do usuario
            Console.Write("Digite sua idade: ");

            //Verificar se a idade do usuario é um numero inteiro se não for vai erro e repetir o loop
            string entradaIdade = Console.ReadLine();

            if (!int.TryParse(entradaIdade, out int idade))
            {
                Console.WriteLine("Você errou. A idade deve ser um número inteiro.");
                return;
            }

            //Perguntar qual é o genero do usuario
            Console.Write("Digite seu gênero com a inicial 'F' ou 'M': ");

            //Vai ler o genero do usuario
            string? entrada = Console.ReadLine();
            //Variavel para verificar se foi apenas uma letra que o usuario digitou
            char genero = ' ';
            
            //Verificação completa que verifica se o usuario digitou apenas uma letra caso o ocontrario retorna um erro e repeti o loop
            if (entrada?.Length == 1 && char.TryParse(entrada, out genero))
            {
                //Aqui Garante que o Usuario Digitou um Numero Maiúsculo
                genero = char.ToUpper(genero); // padroniza para maiúsculo

                //Aqui Menssagem de Erro
                if (genero != 'F' && genero != 'M')
                {
                    Console.WriteLine("Gênero inválido! Digite apenas 'F' ou 'M'.");
                    return;
                }
            }
            else
            {
                //Outra menssagem erro caso o usuario digite uma frase ao inves de apenas uma letra
                Console.WriteLine("Entrada inválida! Digite apenas um caractere.");
            }

            //Aqui Pergunta qual é sua altura
            Console.Write("Digite a sua Altura: ");
            //aqui ja ler como string a altura
            string EntradaAltura = Console.ReadLine();
            //Mais também tem a variavel pra verificar se é extamente um numero double
            double Altura;

            //Verificação da altura
            if (!double.TryParse(EntradaAltura, out Altura))
            {
                Console.WriteLine("Valor inválido! Digite um número decimal válido.");
                return;
            }

            //Se passar por tudo isso vai receber uma nota de 10.0

            double nota = 10.0;

            //Desligar o Loop e Exibir todas as Saidas do Programa
            ligarloop = false;
            Console.WriteLine($"{nome} tem {idade} anos, gênero {genero}, altura de {Altura}m e tirou nota {nota} na prova de Matemática.");
            Console.WriteLine("Programa Finalizado com Sucesso!");
            break;
        }
    }
}



