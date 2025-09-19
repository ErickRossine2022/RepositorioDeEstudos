
/*


    EXERCICIO 1 - VETORES E ARRAYS CURSO DE UNITY PORÉM APLICAÇÃO EM C# PURO

string[] Receita =
{
    "1. Primeiro pegue a escova de Dente",
    "2. Depois pegue o creme dental",
    "3. Coloque o creme na escova",
    "4. Agora é só escovar os dentes",
    "5. Enxague a boca",
    "6. Pronto, você escovou os dentes"
};


Console.WriteLine("Receita de como escovar os dentes\n\n");

for (int i = 0; i < Receita.Length; i++)
{
    Console.WriteLine(Receita[i]);
}

*/

/*
    Diferença entre VAR e TIPOS no C# (int, string, double, float, DateTime, etc)
    VAR = O compilador identifica o tipo da variável automaticamente
    TIPOS = Você define o tipo da variável manualmente
    
    Exemplo:
    var nome = "Erick"; // O compilador identifica que é uma string
    string nome2 = "Erick"; // Você define que é uma string

    var idade = 20; // O compilador identifica que é um inteiro
    int idade2 = 20; // Você define que é um inteiro
   
    var Data = DateTime.Now; // O compilador identifica que é um DateTime
    DateTime Data2 = DateTime.Now; // Você define que é um DateTime
   
    var altura = 1.75; // O compilador identifica que é um double
    double altura2 = 1.75; // Você define que é um double
   
    var peso = 70.5f; // O compilador identifica que é um float
    float peso2 = 70.5f; // Você define que é um float
   
    var isAluno = true; // O compilador identifica que é um booleano
    bool isAluno2 = true; // Você define que é um booleano


*/

using System.Runtime.CompilerServices;



/*

Loop de Repetição Infinito

while (true)
{
    Exemplo de Como Funciona Manipulção de Var e Tipos

    //Variáveis com VAR

    var nome = "Erick";
    var idade = 20;
    var Data = DateTime.Now;
    Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos. Hoje é dia {Data:dd/MM/yyyy}\n");
    Console.WriteLine("=============== | Agora Vamos Calcular Dados | ======================");
    Console.Write("Digite o primeiro número: ");
    var num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    var num2 = Convert.ToDouble(Console.ReadLine());
    var Resultado = num1 * num2;
    Console.WriteLine($"\no Resultado da multiplicação entre {num1} e {num2} é: {Resultado}");
    Console.WriteLine("===============================================================\n");


    Console.WriteLine("=============== | Agora Vamos Calcular Dados Novamente | ======================");
    Console.WriteLine("\nConta Resolvida com sucesso, Obrigado por usar nosso sistema!");


    //Variáveis com TIPOS

    string name = "Rossine";
    int idade2 = 20;
    DateTime Data2 = DateTime.Now;
    Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos. Hoje é dia {Data:dd/MM/yyyy}\n");
    Console.Write("Digite o primeiro número: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    int number2 = int.Parse(Console.ReadLine());
    int Result = number1 * number2;
    Console.WriteLine($"\no Resultado da multiplicação entre {number1} e {number2} é: {Result}");
    Console.WriteLine("===============================================================");
}

*/

/* 
    Manipulação de Datas com DateTime no C#


DateTime Hoje = DateTime.Now; // Pega a data de hoje
DateTime SemanaQueVem = Hoje.AddDays(7); // Adiciona 7 dias a data de hoje
Console.WriteLine($"Hoje é dia {Hoje:dd/MM/yyyy} e daqui 7 dias será dia {SemanaQueVem:dd/MM/yyyy}");
DateTime SemanaRetrasada = Hoje.AddDays(-7); // Ver Que dia era 7 dias atrás
Console.WriteLine($"Hoje é dia {Hoje:dd/MM/yyyy} e 7 dias atrás era dia {SemanaRetrasada:dd/MM/yyyy}");
DateTime ProximoMes = Hoje.AddMonths(1); // Ver Que dia será daqui 1 mês
Console.WriteLine($"Hoje é dia {Hoje:dd/MM/yyyy} e daqui 1 mês será dia {ProximoMes:dd/MM/yyyy}");
DateTime AnoPassado = Hoje.AddYears(-1); // Ver Que dia era 1 ano atrás
Console.WriteLine($"Hoje é dia {Hoje:dd/MM/yyyy} e 1 ano atrás era dia {AnoPassado:dd/MM/yyyy}");
DateTime AnoQueVem = Hoje.AddYears(1); // Ver Que dia será daqui 1 ano
Console.WriteLine($"Hoje é dia {Hoje:dd/MM/yyyy} e daqui 1 ano será dia {AnoQueVem:dd/MM/yyyy}");
DateTime HoraMaisUma = Hoje.AddHours(1); // Ver Que horas será daqui 1 hora
Console.WriteLine($"Agora são {Hoje:HH:mm} e daqui 1 hora será {HoraMaisUma:HH:mm}");
DateTime HoraMenosUma = Hoje.AddHours(-1); // Ver Que horas era 1 hora atrás
Console.WriteLine($"Agora são {Hoje:HH:mm} e 1 hora atrás era {HoraMenosUma:HH:mm}");
DateTime MinutoMaisUm = Hoje.AddMinutes(1); // Ver Que horas será daqui 1 minuto
Console.WriteLine($"Agora são {Hoje:HH:mm} e daqui 1 minuto será {MinutoMaisUm:HH:mm}");
DateTime MinutoMenosUm = Hoje.AddMinutes(-1); // Ver Que horas era 1 minuto atrás
Console.WriteLine($"Agora são {Hoje:HH:mm} e 1 minuto atrás era {MinutoMenosUm:HH:mm}");

*/

/*

Exercicios do Curso de C# - Parte 1 Crie um sistema que Leia dois numeros e mostre um menu de opções (soma, subtração, multiplicação, divisão e sair). O sistema deve realizar a operação escolhida entre os dois numeros e mostrar o resultado. O sistema deve continuar rodando até que a opção de sair seja escolhida.

while (true)
{
    Console.Write("Digite um Numero: ");
    float number1 = float.Parse(Console.ReadLine());
    Console.Write("Digite Outro Numero: ");
    float number2 = float.Parse(Console.ReadLine());

    Console.WriteLine("=============== | Escolha um Operador | ==================");
    Console.WriteLine("1. Soma (+)");
    Console.WriteLine("2. Subtração (-)");
    Console.WriteLine("3. Multiplicação (*)");
    Console.WriteLine("4. Divisão (/)");
    Console.WriteLine("5- Sair (0)");
    Console.WriteLine("=========================================================");

    int operacao = int.Parse(Console.ReadLine());

    switch (operacao)
    {
        case 1:
            float resultadoSoma = number1 + number2;
            Console.WriteLine($"O Resultado da Soma entre {number1} e {number2} é: {resultadoSoma}");
        break;

        case 2:
            float resultadoSubtracao = number1 - number2;
            Console.WriteLine($"O Resultado da Subtração entre {number1} e {number2} é: {resultadoSubtracao}");
        break;

        case 3:
            float resultadoMultiplicacao = number1 * number2;
            Console.WriteLine($"O Resultado da Multiplicação entre {number1} e {number2} é: {resultadoMultiplicacao}");
        break;

        case 4:
            if (number2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
            }
            else
            {
                float resultadoDivisao = number1 / number2;
                Console.WriteLine($"O Resultado da Divisão entre {number1} e {number2} é: {resultadoDivisao}");
            }
        break;

        case 5:
            Console.WriteLine("Obrigado por usar nosso sistema!");
        break;

        default: 
            Console.WriteLine("Opção Invalida!.");
        break;
    }
}
*/


/*

Exercicios do Curso de C# - Parte 2 Escolha um Numero e Exiba o Resultado de Cada Operação se baseando no Numero Digitado

Console.Clear(); // Limpa o console

while (true)
{
    Console.WriteLine("Digite um Número que Voce Queira ver Todas As Operacoes de 1 a 10 do numero digitado: ");
    int num = int.Parse(Console.ReadLine());

    for (int i = 1; i < 10; i++)
    {
        Console.WriteLine($"{num} + {i} = {num + i}\t{num} - {i} = {num - i}\t{num} x {i} = {num * i}\t{num} ÷ {i} = {num / i}");
    }
    
}

*/

/*

    Simule um Jogo Onde o Inimigo e  Player Tenham 100 de vida e Gere um Numero para cada
    onde vai vim uma função aleatoria e abaixar a vida ou do Player ou Inimigo se Baseando na Função aleatoria
    se for um numero de 10 a 21 é Atack de Player se for entre um numero de 5 ou 16 é Atack de inimigo



float PlayerHealth = 100.0f;
float EnemyHealth = 100.0f;

Console.WriteLine("Bem Vindo ao Jogo de Batalha!");
Console.WriteLine("Você é um Guerreiro que tem que derrotar o Inimigo.");
Console.WriteLine("Você e o Inimigo começam com 100 de Vida.");
Console.WriteLine("Cada ataque tira uma quantidade de vida do oponente.");
Console.WriteLine("Quem chegar a 0 de vida primeiro perde o jogo.");

Console.WriteLine("Vamos Começar a Batalha!");
Console.Write("Pressione Enter para iniciar...");
Console.ReadLine();
Console.Clear();

Random Rand = new Random(); // Função para gerar um Número Aleatorio no SIstema

while (PlayerHealth > 0 && EnemyHealth > 0)
{
    int PlayerAtack = Rand.Next(10, 21);
    int EnemyHealthAtack = Rand.Next(5, 16);
    EnemyHealth -= PlayerAtack;
    PlayerHealth -= EnemyHealthAtack;
    Console.WriteLine($"Você atacou o Inimigo e tirou {PlayerAtack} de vida.");
    Console.WriteLine($"O Inimigo atacou você e tirou {EnemyHealthAtack} de vida.");
    Console.WriteLine($"Sua Vida: {PlayerHealth}\tVida do Inimigo: {EnemyHealth}");
    Console.WriteLine("---------------------------------------------------");
    Console.Write("Pressione Enter para continuar...");
    Console.ReadLine();
}
while (PlayerHealth <= 0 || EnemyHealth <= 0)
{
    if (PlayerHealth <= 0 && EnemyHealth <= 0)
    {
        Console.WriteLine("Empate! Ambos morreram ao mesmo tempo.");
    }
    else if (PlayerHealth <= 0)
    {
        Console.WriteLine("Você perdeu! O Inimigo te derrotou.");
    }
    else
    {
        Console.WriteLine("Você venceu! Parabéns, você derrotou o Inimigo.");
    }
    break;
}   

*/


float PlayerHealth = 100.0f;
float EnemyHealth = 100.0f;

Console.WriteLine("Iniciando Gameplay Entre o Player e o Inimigo");
Console.WriteLine("Nesse jogo o Player e o Inimigo poderão ser afetados pelo Jogo da Sorte");
Console.WriteLine("Quem chegar a 0% de vida perderá!");
Console.WriteLine("Vamos começar!\n");

Random Aleatorio = new Random();

while (PlayerHealth > 0 && EnemyHealth > 0)
{
    float PlayerAttack = Aleatorio.Next(15, 21);
    float EnemyAttack = Aleatorio.Next(5, 10);

    // Correção aqui ↓
    EnemyHealth -= PlayerAttack;
    PlayerHealth -= EnemyAttack;

    Console.WriteLine($"Você tirou {PlayerAttack}% de vida do Inimigo");
    Console.WriteLine($"O Inimigo tirou {EnemyAttack}% de vida de você");
    Console.WriteLine($"Sua vida: {PlayerHealth}% | Vida do inimigo: {EnemyHealth}%");
    Console.WriteLine("---------------------------------------------");
    Console.ReadLine(); // pausa para acompanhar rodada
}

if (PlayerHealth <= 0 && EnemyHealth <= 0)
{
    Console.WriteLine("Nenhum dos dois ganhou o jogo (empate)!");
}
else if (PlayerHealth <= 0)
{
    Console.WriteLine($"Você perdeu o jogo! Sua vida chegou a {PlayerHealth}%.");
}
else
{
    Console.WriteLine($"Parabéns! Você venceu o jogo! Vida restante: {PlayerHealth}%.");
}
























