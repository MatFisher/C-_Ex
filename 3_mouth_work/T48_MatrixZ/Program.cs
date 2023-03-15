int[,] FillMatrixRndInt(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
        for(int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().Next(1,10); //
        }
    }
    return matrix;
}

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


int[,] matr = new int [3, 4];
Console.WriteLine();
matr = FillMatrixRndInt(matr);
PrintMatrix(matr);
Console.WriteLine();