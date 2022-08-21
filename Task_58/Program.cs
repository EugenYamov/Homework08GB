// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

/// Объявляем массивы одинаковой размерности
int [,] firstMatrix = GetMatrix(2, 3);
int [,] secondMatrix = GetMatrix(2, 3);
int [,] resultMatrix = new int[2, 3];

/// Алгоритм поэлементого умножения двух массивов
for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] += firstMatrix[i,j] * secondMatrix[i,j];
        }
    }

/// Вывод результата вычислений         
Console.WriteLine("\nПервая матрица:\n");
PrintMatrix(firstMatrix);
Console.WriteLine("Вторая матрица:\n");
PrintMatrix(secondMatrix);
Console.WriteLine("Результат произведения:\n");
PrintMatrix(resultMatrix);