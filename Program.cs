namespace AtividadeArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
            int[] tresValores = EncontrarMaiores(valores, 3);
            int[] valoresNegativos = EncontrarNegativos(valores);
            int[] novosValores = RemoverItem(valores);

            Console.WriteLine($"O maior valor da sequência é: {EncontrarMaiorValor(valores)}");
            Console.WriteLine($"O menor valor da sequência é:{EncontrarMenorValor(valores)}");
            Console.WriteLine($"O valor médio da sequência é: {EncontrarValorMedio(valores)}");
            Console.Write("Os três maiores valores são: "); MostrarValores(tresValores);
            Console.Write("Os valores do array: "); MostrarValores(valores);
            Console.Write("Os valores negativos da frequência são: "); MostrarValores(valoresNegativos);
            Console.Write("Os valores da sequência após a remoção do item: "); RemoverItem(valores);
            MostrarValores(novosValores);
        }   
        static int EncontrarMaiorValor(int[] valores)
        {
            int maior = valores[0];

            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] > maior)
                {
                    maior = valores[i];
                }
            }

            return maior;
        }
        static int EncontrarMenorValor(int[] valores)
        {
            int menor = valores[0];

            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] < menor)
                {
                    menor = valores[i];
                }
            }

            return menor;
        }
        static int EncontrarValorMedio(int[] valores)
        {
            int valorMedio = valores.Sum() / valores.Length;
            return valorMedio;

        }
        static void MostrarValores(int[] valores)
        {
            foreach (int valor in valores)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
        }
        static int[] EncontrarNegativos(int[] valores)
        {
            return Array.FindAll(valores, x => x < 0);
        }
        static int[] EncontrarMaiores(int[] valores, int valoresMaiores)
        {
            return valores.OrderByDescending(x => x).Take(valoresMaiores).ToArray();
        }
        static int[] RemoverItem(int[] valores)
        {
            List<int> lista = valores.ToList();
            lista.Remove(1);
            return lista.ToArray();
        }
    }
}