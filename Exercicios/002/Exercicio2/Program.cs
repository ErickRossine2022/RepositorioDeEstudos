﻿using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main()
        {
            //Perguntar o Nome Completo do Usuario
            Console.Write("Digite seu nome Completo: ");
            string name = Console.ReadLine();

            //Perguntar Quantos Quartos tem na casa
            Console.Write("Quantos Quartos tem na sua casa: ");
            int Quartos = int.Parse(Console.ReadLine());

            //Perguntar Quanto custa a Casa
            Console.Write("Quanto custa a Casa: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Imprimir as Variaveis na Tela
            Console.WriteLine(name);
            Console.WriteLine(Quartos);
            //Ler o Valor com o Pontinho e não com Virgula
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));

            //Perguntar qual foi o Ultimo nome a idade do usuario e Altura na mesma linha
            Console.Write("Digite seu ultimo nome, sua idade, sua altura (mesma linha): ");
            //Ler e Guardar o nome idade altura em um Array
            string[] info = Console.ReadLine().Split(' ');
            
            //Pegar oque foi guardado no Array com sua respectiva variavel
            string UltimoName = info[0];
            int idade = int.Parse(info[1]);
            double Altura = double.Parse(info[2], CultureInfo.InvariantCulture);
            
            //Imprimir Informações com Precisão
            Console.WriteLine(UltimoName);
            Console.WriteLine(idade);
            Console.WriteLine(Altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}