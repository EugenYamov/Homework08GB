// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/// Метод описывающий заполенение трехмерного массива
int [,,] Get3DMatrix(int rows, int columns, int depth)
{
    int [,,] matrix = new int[rows, columns, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
                matrix[i,j,k] = new Random().Next(10, 100);
           }
        }
    }
    return matrix;
}

/// Метод описывающий вывод массива на экран
void PrintMatrix(int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]} ({i},{j},{k})\t");
            }
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int [,,] matrix = Get3DMatrix(2, 2, 2);

PrintMatrix(matrix);