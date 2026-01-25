using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 2 && j == 2)
                    matrix[i, j] = 1;
                else
                    matrix[i, j] = 0;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix[i, j]);
                if (j < 4)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}