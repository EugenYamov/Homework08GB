// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/// Метод описывающий заполенение двумерного массива
int [,] GetMatrix(int rows, int columns)
{
    int [,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10); 
        }
    }
    return matrix;
}

/// Метод описывающий вывод массива на экран
void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int [,] matrix = GetMatrix(4, 3);

/// Метод подсчета суммы чисел в строке массива
int SumRowMatrix(int[,] matrix, int i)
{
  int sumRow = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumRow += matrix[i,j];
  }
  return sumRow;
}

/// Алгоритм нахождения строки с найменьшей суммой элементов
int minSumRow = 0;
int sumRow = SumRowMatrix(matrix, 0);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int tempSumRow = SumRowMatrix(matrix, i);
    if (sumRow > tempSumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}

System.Console.WriteLine("\nМатрица чисел:\n");
PrintMatrix(matrix);

System.Console.WriteLine($"\n№{minSumRow + 1} - строка с наименьшей суммой элементов ({sumRow}).\n");