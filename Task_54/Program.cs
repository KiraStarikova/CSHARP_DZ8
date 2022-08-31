// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int[,] matrix = CreateMatrix(3,4,0,10);
PrintMatrix(matrix);
Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(matrix);
PrintMatrix(matrix);