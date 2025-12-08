namespace TiposValorEreferencia
{
    class Program
    {
        static void Main()
        {
            //Direrencia do Tipo valor para o Tipo Referencia
            //o Tipo referencia ele 
            Produto p1, p2;

            //Cria uma nova instancia de um objeto
            p1 = new Produto("TV", 1, 900.00);
            //Caso o Segundo objeto receba o primeiro objeto
            //o Segundo Objeto Passa a pontar para o primeiro objeto 
            //assim fazendo com que o objeto sempre referencia ao outro
            //se mundar um munda o outro
            p2 = p1;

            //o Tipo Struct seria no caso tipo valor 
            //quando você cria uma variavel do Tipo Produto2
            //que é um struct e declara ela como p3 e p4
            //você cria duas struct do tipo valor
            Produto2 p3, p4;
            //Aqui você instancia um objeto para a variavel p3
            p3 = new Produto2("TV", 1, 900.00);
            //Aqui Você recebe uma copia do p3
            //para o p4
            p4 = p3;


            Console.Clear();

            Console.WriteLine("===============================================================================");
            Console.WriteLine("Explicação");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.WriteLine("Abaixo Vamos Mostrar no Console a Diferença entre o Tipo Valor");
            Console.WriteLine("Para o Tipo Refêrencia");
            Console.WriteLine("Tipo Valor [Struct] e Tipo Refêrencia [Classe]");
            Console.WriteLine("p1 e p2 são Tipos Refêrencia e p3 e p4 são Tipos valor");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.WriteLine("p1 irá apontar para um objeto p2 para o mesmo objeto assim");
            Console.WriteLine("quando você edita um o outro tambèm será editado");
            Console.WriteLine("");
            Console.WriteLine("já p3 e p4 enquanto o p3 cria o objeto do tipo valor");
            Console.WriteLine("o p4 cria uma copia do objeto p3 assim tendo dois objetos iguais");
            Console.WriteLine("assim quando você atualiza o valor de 1 o outro não é afetado!");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.WriteLine("Teste Abaixo:");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");


            Console.WriteLine("===============================================================================");
            Console.WriteLine($"tipo Referencia: {p1}");
            Console.WriteLine($"Imprimir p2 Referenecia do p1: {p2}");
            Console.WriteLine("");
            Console.WriteLine($"Tipo Valor p3: {p3}");
            Console.WriteLine($"Copia do P3 o p4: {p4}");
            Console.WriteLine("");
            Console.WriteLine("Adicione uma Quantidade para o p4: ");
            Console.WriteLine("===============================================================================");

            int input = int.Parse(Console.ReadLine());

            p4.AddQuantidade(input);
            Console.WriteLine("===============================================================================");
            Console.WriteLine($"P3 Atualizado: {p3} reais");
            Console.WriteLine($"P4 Atualizado: {p4} reais");
            Console.WriteLine("===============================================================================");

            Console.WriteLine("");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("QUANDO USAR TIPO REFERÊNCIA (Class) vs TIPO VALOR (Struct)");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("");
            Console.WriteLine("USE CLASS (Tipo Referência) QUANDO:");
            Console.WriteLine("• O objeto é grande ou complexo (muitos atributos)");
            Console.WriteLine("• Você precisa que múltiplas variáveis apontem para o MESMO objeto");
            Console.WriteLine("• O objeto será compartilhado e modificado em vários lugares do código");
            Console.WriteLine("• Exemplo: Usuário, Produto em um e-commerce, Conta bancária");
            Console.WriteLine("  (se mudou em um lugar, deve mudar em tudo que referencia)");
            Console.WriteLine("");
            Console.WriteLine("USE STRUCT (Tipo Valor) QUANDO:");
            Console.WriteLine("• O objeto é pequeno e simples (poucos atributos)");
            Console.WriteLine("• Você quer que CADA variável tenha sua PRÓPRIA cópia independente");
            Console.WriteLine("• Modificações em uma variável não devem afetar outras");
            Console.WriteLine("• Exemplo: Ponto(X, Y), Data, Hora, Cor(R, G, B)");
            Console.WriteLine("  (valores que não precisam ser compartilhados)");
            Console.WriteLine("");
            Console.WriteLine("RESUMO:");
            Console.WriteLine("• Class = referência compartilhada (heap) = comportamento de PONTEIRO");
            Console.WriteLine("• Struct = cópia independente (stack) = comportamento de VALOR");
            Console.WriteLine("===============================================================================");

        }
    }
}