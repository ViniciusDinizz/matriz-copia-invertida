using System.Data.Common;

internal class Program
{
    //Ler valores em uma matriz, e copiar os valores invertidos em uma metriz secundária
    private static void Main(string[] args)
    {
        int[,] matriz1 = new int[3, 3];
        int[,] matrizcop = new int[3, 3];
     
        matriz1 = LerMatriz(matriz1);

        matrizcop = Inverter(matriz1);

        ImprimirMatriz(matriz1);
        Console.WriteLine();
        Console.WriteLine("  Invertida");
        ImprimirMatriz(matrizcop);

        void ImprimirMatriz (int[,] matriz)
        {
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++)
                {
                    Console.Write($"  {matriz[linha,coluna]}  ");
                }
                Console.WriteLine();
            }
        }
        
        int[,] Inverter(int[,] Matriz)
        {
            int[,] matrizinvertida = new int[Matriz.Length, Matriz.Length];

            for(int linha = 2; linha >= 0; linha--)
            {
                for(int coluna = 2; coluna >= 0; coluna--)
                {
                    int indice = 2;
                    matrizinvertida[indice - linha, indice - coluna] = Matriz[linha, coluna];
                }
            }
            return matrizinvertida;
        }

        int[,] LerMatriz(int[,] Matriz)
        {
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Informe o valor {coluna+1}, da linha {linha+1}: ");
                    Matriz[linha, coluna] = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
            return Matriz;
        }
    }
}