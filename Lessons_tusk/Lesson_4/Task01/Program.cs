﻿// string[,] table = new string[2, 5];
// table[1, 2] = "word";

// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"{table[rows, columns]}");
//     }
// }

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrixRndInt(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
        for(int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().Next(1,10); //
        }
    }
}

int[,] matr = new int [3, 4];
PrintMatrix(matr);
Console.WriteLine();
FillMatrixRndInt(matr);
PrintMatrix(matr);
