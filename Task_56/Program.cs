// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for(int row = 0; row < rowCount; ++row)
    {
        for(int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for(int row = 0; row < arr.GetLength(0); ++row)
    { 
        for(int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t"); 
        }
        Console.WriteLine();
    }
}

void ArrayMinSumLine(int[,] arr)
{
    int minSumLine = 0;
    int sumLine = SumLineElements(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(arr, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }

    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


    int SumLineElements(int[,] array, int i)
    {
        int sumLine = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sumLine += array[i,j];
        }
        return sumLine;
    }
}


int[,] matrix = CreateMatrix(4,5,0,10);
PrintMatrix(matrix);
ArrayMinSumLine(matrix);
