using System.Data.Common;

internal class Program
{
    //Ler valores em uma matriz, e copiar os valores invertidos em uma metriz secundária
    private static void Main(string[] args)
    {
        int[,] matriz1 = new int[3, 3];
        int[,] matrizcop = new int[3, 3];
        Random aleatorio = new Random();

        matriz1 = LerMatriz(matriz1);

        matrizcop = Inverter(matriz1);

        ImprimirMatriz(matriz1);
        Console.WriteLine();
        Console.WriteLine("  Invertida");
        ImprimirMatriz(matrizcop);

        //Realiza a impressão da matriz
        void ImprimirMatriz(int[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write($"  {matriz[linha, coluna]}  ");
                }
                Console.WriteLine();
            }
        }

        //Inverte os valores de uma matriz para outra
        int[,] Inverter(int[,] Matriz)
        {
            int[,] matrizinvertida = new int[Matriz.GetLength(0), Matriz.GetLength(1)];

            for (int linha = Matriz.GetLength(0)-1; linha >= 0; linha--)
            {
                for (int coluna = Matriz.GetLength(1)-1; coluna >= 0; coluna--)
                {
                    int indice = Matriz.GetLength(0)-1;
                    matrizinvertida[indice - linha, indice - coluna] = Matriz[linha, coluna];
                }
            }
            return matrizinvertida;
        }

        //Grava valores em uma matriz de forma automatica e pseudo aleatória
        int[,] LerMatriz(int[,] Matriz)
        {
            for (int linha = 0; linha < Matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < Matriz.GetLength(1); coluna++)
                {
                    Matriz[linha, coluna] = aleatorio.Next(10);
                }
            }
            return Matriz;
        }
    }
}