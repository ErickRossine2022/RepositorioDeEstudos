namespace ModificadorParams
{
    class Calculator
    {
        /*
                CLASSE CALCULATOR EM INGLÊS CALCULADORA 


        EXPLICAÇÃO DO METODO SUM <-- SOMA

        ele cria um metodo statico sum e passa o vetor de numeros numbers como paramentro usando o modificador
        params ae dentro do metodo ele cria uma variavel chamada sum para somar todos os numeros do vetor de numero
        ae depois cria um loop for ler o que está dentro do vetor usando numbers.Length
        e soma tudo usando sum += numbers[i]
        e retorna o resultado
        
        */
        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}