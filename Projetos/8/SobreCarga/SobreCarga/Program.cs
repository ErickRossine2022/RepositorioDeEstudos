namespace SobreCarga
{
    class Program
    {
        static void Main()
        {
            //Instanciar um Construtor Vazio quando ele estiver Vazio
            Teste objeto1 = new Teste();
            //Instanciar um Construtor Com 3 paramentros Caso tenha 3 paramentros
            Teste objeto2 = new Teste("odsblankil", "123", "132.153.152-05");
            //Instanciar um Construtor com 2 Paramentros caso tenha 2 paramentros
            Teste objeto3 = new Teste("odsblankil", "123");
            
            //mais uma maneira de isntanciar um construtor ultilizando
            //o Objeto do tipo Teste e adicionar valores aos atributos
            //dentro das chaves { para abrir } para fechar
            Teste objeto4 = new Teste
            {
                Email = "marcosrossine123456@gmail.com",
                Password = "meuovo123456",
                CPF = "172.166.163-05"
            };
            
            //Limpar Console e Imprimir os Construtores no Console
            Console.Clear();
            Console.WriteLine("Imprimir Construtores e Sobrecargas");
            Console.WriteLine(objeto1.Email + "\t" + objeto1.Password + "\t" + objeto1.CPF);
            Console.WriteLine(objeto2.Email + "\t" + objeto2.Password + "\t" + objeto2.CPF);
            Console.WriteLine(objeto3.Email + "\t" + objeto3.Password + "\t" + objeto3.CPF);
            Console.WriteLine(objeto4.Email + "\t" + objeto4.Password + "\t" + objeto4.CPF);
            
            
            //Fazer um Array de Strings para teste
            string [] testando =
            {
                "nome 1",
                "nome 2",
                "nome 3",
                "nome 4",
                "nome 5"
            };
            
            //Fazer um array Numerico para teste
            int[] numeroses =
            {
                150,
                120,
                99,
                9999,
                12324,
                157
            };
            
            //Testando um Loop For com Array
            for (int i = 0; i < testando.Length; i++)
            {
                Console.WriteLine(testando[i]);
            }
            
            //testando um Loop Foreach com Array
            foreach (var numeros in numeroses)
            {
                Console.WriteLine(numeros);
            }
        }
    }
}
