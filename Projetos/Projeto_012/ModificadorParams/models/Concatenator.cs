namespace ModificadorParams
{
    // Exemplo: concatenar strings usando `params`
    class Concatenator
    {
        public static string Join(string separator, params string[] parts)
        {
            return string.Join(separator, parts);
        }
    }
}
