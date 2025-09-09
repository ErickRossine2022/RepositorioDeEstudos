using System;
using System.Globalization;

/*
    Convenções de nomes no C#

    Camel Case: lastName (usados em parãmentros de metódos, varíaveis de metódos) 
    Começa com a primeira letra menusculo quando começa outra Palavrá Maiusculo Também a Segunda Letra da Palavrá

    Exemplo Camel Case: string primeiraVariavel = "Blank1ll";


    Pascal Case: LastName(usados em namespace, classe,  properties e metódos)
    Começa com a primeira Letra maiuscolo quando começa outra Palavrá Maiusculo Também a Segunda Letra da Palavrá

    Exemplo Pascal Case: string PrimeiraVariavel = "Blank1ll";


    Padrão: _lastName(usados em atributos "internos" da classe)
    Começa com anderline depois nome da variavel em Camel Case

    Exemplo Padrão: string _primeiraVariavel = "Blank1ll";

*/

namespace ProjetoDeApredizado
{
    class Program
    {
        static void Main()
        {
            string produto = "Computador";
            string produto2 = "Mesa de Scritorio";

            byte idade = 20;
            int Codigo = 5290;
            char Genero = 'M';

            double preco = 2100.00;
            double preco2 = 650.00;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto}, cujo o preço é {preco}");
            Console.WriteLine($"{produto2}, cujo o preço é {preco2}\n");
            Console.WriteLine($"Registro: {idade} de idade, Codigo: {Codigo}, Genero: {Genero}\n");
            Console.WriteLine($"Medida de Oito Casas Decimais: {medida:F8}");
            Console.WriteLine($"Medida de 3 Casas Decimais: {medida:F3}");
            Console.WriteLine("Separador Decimal Invariante Colture; " + medida.ToString("F8", CultureInfo.InvariantCulture));

        }
    }

}





/*

    BACKUP DA ESTRUTURA PADRÃO
namespace ProjetoDeApredizado
{
    class Program
    {
        static void Main()
        {
                
        }
    }

}
*/



/*

    Para Controlar o numero de casa decimais com variaveis Double

Console.WriteLine($"o Usuario possui :{money.ToString("F1")} de reais");
Console.WriteLine($"o Usuario possui :{money.ToString("F2")} de reais");
Console.WriteLine($"o Usuario possui :{money.ToString("F3")} de reais");
Console.WriteLine($"o Usuario possui :{money.ToString("F4")} de reais");
Console.WriteLine($"o Usuario possui :{money.ToString("F5")} de reais");
Console.WriteLine($"o Usuario possui :{money.ToString("F6")} de reais");


Console.WriteLine($"o Usuario possui :{money:F1} de reais");
Console.WriteLine($"o Usuario possui :{money:F2} de reais");
Console.WriteLine($"o Usuario possui :{money:F3} de reais");
Console.WriteLine($"o Usuario possui :{money:F4} de reais");
Console.WriteLine($"o Usuario possui :{money:F5} de reais");
Console.WriteLine($"o Usuario possui :{money:F6} de reais");

    Exemplos a Cima Controle de Casas decimais com variaveis double

    EXERCICIO LOGO ABAIXO 


namespace ProjetoDeApredizado
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            string name = "Erick Rossine";
            int age = 20;
            double money = 10.00000;

            Console.WriteLine($"Usuario: {name} Idade: {age} anos Possui {money.ToString("F2")} reais");
            Console.WriteLine("Usuario: {0} Idade: {1} anos Possui {2:F2} reais", name, age, money);
            Console.WriteLine($"Usuario: {name} Idade: {age} anos Possui {money:F2} reais");
        }
    }

}

*/



/*

    O EXERCICIO QUE ERA PRA FAZER E EU CONSIGUIR FAZER COM MAESTRIA

namespace ProjetoDeApredizado
{
    class Program
    {
        static void Main()
        {
            

            Console.Write("Digite um Numero: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Digite segundo Numero: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number + number2;
            Console.WriteLine($"o Resultado de {number} + {number2} = {result}");

            O DE BAIXO ERA PRA SER O PRIMIERO EXERCIO MAIS FUI INVENTAR MODA

            while (true)
            {
                int conta = 30 + 40;
                int conta2 = 70 + 30;

                Console.WriteLine($"a soma de 30 + 40 = {conta} e o Resultado de soma2 70 + 30 = {conta2}");
                Console.WriteLine($"Agora que sabemos que 30 + 40 da = {conta} e 70 + 30 = {conta2}");
                Console.WriteLine("Qual seria a Resposta caso se 100 fosse dividido por 5?");
                Console.Write("Digite o Resultado: ");
                int Resultado = int.Parse(Console.ReadLine());

                if (Resultado == 20)
                {
                    int conta3 = 100 / 5;
                    Console.WriteLine($"o Resultado da Divisão está correta porque voçê respondeu: {conta3}");
                }
                else
                {
                    Console.WriteLine($"Voçê Errou a Conta 100 / 5 = não è {Resultado} Jumento!");
                }
            }
        }
    }
}
*/



/*

namespace Corse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ola Mundo");
        }
    }
    class AccountBank
    {
        public string Titular { get; set; }
        private double _Saldo;

        public void Deposito(double Quantia)
        {
            _Saldo += Quantia;
        }

        public double GetSaldo()
        {
            return _Saldo;
        }
    }         
}
*/