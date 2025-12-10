namespace ModificadorParams
{
    // Exemplo: funções estatísticas que aceitam um número variável de argumentos
    class Stats
    {
        // Retorna a média dos valores; se não houver valores, retorna 0
        public static double Average(params double[] values)
        {
            if (values == null || values.Length == 0) return 0;
            double sum = 0;
            foreach (var v in values) sum += v;
            return sum / values.Length;
        }

        // Retorna o menor valor; se não houver valores, retorna NaN
        public static double Min(params double[] values)
        {
            if (values == null || values.Length == 0) return double.NaN;
            double min = values[0];
            foreach (var v in values) if (v < min) min = v;
            return min;
        }

        // Retorna o maior valor; se não houver valores, retorna NaN
        public static double Max(params double[] values)
        {
            if (values == null || values.Length == 0) return double.NaN;
            double max = values[0];
            foreach (var v in values) if (v > max) max = v;
            return max;
        }
    }
}
