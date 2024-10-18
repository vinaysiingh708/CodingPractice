using System;

public class Program
{
    public static void Main()
    {
        // Declare and initialize a 2D matrix (square matrix)
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Primary Diagonal:");
        PrintPrimaryDiagonal(matrix);

        Console.WriteLine("\nSecondary Diagonal:");
        PrintSecondaryDiagonal(matrix);
    }

    // Function to print the primary diagonal (top-left to bottom-right)
    public static void PrintPrimaryDiagonal(int[,] matrix)
    {
        int n = matrix.GetLength(0); // Number of rows (also columns in square matrix)
        for (int i = 0; i < n; i++)
        {
            Console.Write(matrix[i, i] + " ");
        }
    }

    // Function to print the secondary diagonal (top-right to bottom-left)
    public static void PrintSecondaryDiagonal(int[,] matrix)
    {
        int n = matrix.GetLength(0); // Number of rows (also columns in square matrix)
        for (int i = 0; i < n; i++)
        {
            Console.Write(matrix[i, n - 1 - i] + " ");
        }
    }
}
