using System.Globalization;
using System.IO.IsolatedStorage;

namespace ExercicioList
{
    class Funcionario
    {
        public int Id { get; set; }
        public string? Name { get; set;}

        public double Salary { get; private set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public double RaiseSalary(int porcentagem)
        {
            double result =  Salary + (Salary * (porcentagem / 100.0));
            Salary = result;
            return Salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}\tNome: {Name}\tSalario: {Salary.ToString("F2",CultureInfo.InvariantCulture)} reais";
        }
    }
}