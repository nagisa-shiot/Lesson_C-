int [,] CreateMatrix (int rowCountm, int columsCount) 
{
    int[,] matrix = new int[rowCountm, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1,1000);
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

int [,] matrix = CreateMatrix(3,4);
ShowMatrix(matrix);

foreach (int e in matrix)
{
    if(isInteresting(e)==true)
    {
        System.Console.WriteLine(e);
    }
}

bool isInteresting(int value)
{
   int sumOfDigits = GetSumOfDigits(value);
   if(sumOfDigits%2==0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)
{
    int sum =0;
    while(value>0)
    {
        sum=sum + value%10;
        value=value/10;
    }
    return sum;
}