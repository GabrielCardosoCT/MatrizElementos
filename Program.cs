using System;

class Program
{
    static void Main(string[] args)
    {
        //Variável
        int[,] mat = new int[3, 3];
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento {i + 1},{j + 1}: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Elementos da primeira linha: ");
        for (int j = 0; j < 3; j++)
        {
            Console.Write(mat[0, j] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
