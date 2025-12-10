namespace ModificadorParams
{
    // Exemplo: método de extensão que recebe `params`
    static class StringExtensions
    {
        public static string JoinWith(this string separator, params string[] parts)
        {
            return string.Join(separator, parts);
        }
    }
}
