// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

/// Метод сортировки массива построчно по убыванию.
void SortMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}

int [,] matrix = GetMatrix(3, 5);
System.Console.WriteLine("\nИсходный Массив:\n");
PrintMatrix(matrix);

SortMatrix(matrix);

System.Console.WriteLine("\nОтсортированный массив:\n");
PrintMatrix(matrix);