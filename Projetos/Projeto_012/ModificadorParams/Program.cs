namespace ModificadorParams
{
    class Program
    {
        static void Main()
        {
            // Exemplo básico: usando o modificador `params` na chamada direta
            int s1 = Calculator.Sum(2, 6, 9); // pode passar valores separados
            Console.WriteLine($"Sum(2,6,9) = {s1}");

            // Também é possível passar um array explicitamente
            int[] valores = new int[] { 1, 2, 3, 4 };
            Console.WriteLine($"Sum(array) = {Calculator.Sum(valores)}");

            // Exemplo com métodos genéricos que aceitam `params`
            GenericPrinter.PrintAll<int>(10, 20, 30);
            GenericPrinter.PrintAll<string>("a", "b", "c");

            // Exemplo: valores estatísticos com `params`
            Console.WriteLine($"Média = {Stats.Average(2.0, 4.0, 6.0)}");
            Console.WriteLine($"Min = {Stats.Min(5.5, 1.2, 9.0)}");

            // Exemplo: concatenar strings com `params`
            Console.WriteLine(Concatenator.Join(", ", "maçã", "banana", "laranja"));

            // Exemplo: método que usa `params object[]` para formatação
            Logger.Log("Usuario: {0}, Ação: {1}", "erick", "login");

            // Exemplo: usar um método de extensão com `params`
            string sep = " - ";
            Console.WriteLine(sep.JoinWith("um", "dois", "três"));

            // Demonstração de passar zero argumentos: o array será vazio
            Console.WriteLine($"Sum() = {Calculator.Sum()}");

            // Pequeno exemplo: registrar e autenticar usando AuthService + PasswordHelper
            // (didático — não use senhas em texto em produção)
            var auth = new AuthService();
            string senha = "senha123";
            string hashed = PasswordHelper.HashPassword(senha);
            auth.Register("alice", hashed, "alice@example.com");

            bool autenticado = PasswordHelper.VerifyPassword(hashed, "senha123");
            Console.WriteLine($"Usuario 'alice' autenticado? {autenticado}");
        }
    }
}