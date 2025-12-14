using System.Globalization;

namespace ExercicioList
{
    class Program
    {
        static readonly List<Funcionario> employee = new ();
        static void Main()
        {
            string NameUn = "Nenhum";
            double NameTwo = 0;
            bool found = false;

            Console.Clear();
            Console.WriteLine("Digite um Numero: ");
            int number = int.Parse(Console.ReadLine() ?? " ");

            for (int i = 0; i < number; i++)
            {
                int ID = 1 + i;
                Console.WriteLine("Digite seu Nome: ");
                NameUn = Console.ReadLine() ?? "Nenhum";

                Console.WriteLine("Digite seu Salario: \n");
                NameTwo = double.Parse(Console.ReadLine() ?? "Nada Digitado", CultureInfo.InvariantCulture);

                employee.Add(new Funcionario(ID, NameUn, NameTwo));
            }
            Console.WriteLine("");
            foreach (var fun in employee)
            {
                Console.WriteLine(fun);
            }
            Console.WriteLine("");
            Console.WriteLine("Digite o ID para Aumentar o Salario: ");
            int IDemployee = int.Parse(Console.ReadLine() ?? "Nada Digitado");
            Console.WriteLine("Digite a Porcetagem de ( 1 a 1000): ");
            int P = int.Parse(Console.ReadLine() ?? "Nada Digitado");

            foreach (var fun2 in employee)
            {
                if(fun2.Id == IDemployee)
                {
                    Console.WriteLine($"Salario Atualizado: {fun2.RaiseSalary(P).ToString("F2", CultureInfo.InvariantCulture)}");
                    found = true;
                }
            }

            if(!found)
            {
                Console.WriteLine("ID Invalido Programa Encerrado!");
                return;
            }

            Console.WriteLine("");
            foreach (var fun in employee)
            {
                Console.WriteLine(fun);
            }
        }
    }
}