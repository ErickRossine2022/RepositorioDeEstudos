class Program
{
    static void Main()
    {
        UserInformacoes user = new();
        user.Sistema();

        Console.WriteLine("================= | Todos os usuarios | ============================\n");
        UserInformacoes.MostrarTodosUsuarios();
        Console.WriteLine("======================================================================");
    }
}

