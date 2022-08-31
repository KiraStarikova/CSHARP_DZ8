// Составить частотный словарь элементов двумерного массива, 
//которыйсодержит информацию о том, 
//сколько раз встречается элемент входных данных.

void CreateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = 4;
int n = 4;
int[,] array = new int[m, n];

CreateMatrix(array);
PrintMatrix(array);
Console.WriteLine();

void CreateDictionary(int[,] array)
{
    int[,] dictionary = new int[m * n, 2];
    int k = 0;

    bool exist = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            exist = false;
            for (int r = 0; r < k; r++)
            {
                if (dictionary[r, 0] == array[i, j])
                {
                    dictionary[r, 1]++;
                    exist = true;
                    break;
                }
            }
                if (exist == false)
                {
                    dictionary[k, 0] = array[i, j];
                    dictionary[k, 1]++;
                    k++;
                }
        }
    }
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < dictionary.GetLength(1); j++)
        {
            Console.Write($"{dictionary[i, +j]} ");
        }
        Console.WriteLine();
    }
}

CreateDictionary(array);