using System;

namespace ModificadorParams
{
    // Exemplo: usar `params object[]` para formatação flexível
    class Logger
    {
        public static void Log(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
