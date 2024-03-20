 //int[,] matrix = new int[4, 5];

//Random rand = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = rand.Next(1, 11);
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         System.Console.Write($"{matrix[i, j]} ");
//     }
//     System.Console.WriteLine();
// }

int [,] CreateMatrix (int rowCountm, int columsCount) 
{
    int[,] matrix = new int[rowCountm, columsCount];

Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1,11);
    }
}
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
}
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);