using System;

namespace ModificadorParams
{
    // Exemplo: método genérico com `params`
    class GenericPrinter
    {
        public static void PrintAll<T>(params T[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
