//Объявляем размерность матрицы
int size = 4;

// Объявляем массив с заданным размером
int[,] matrix = new int[size, size];

int temp = 1;
int i = 0;
int j = 0;

// Алгоритм для спиральной записи элементов 

while (temp <= matrix.GetLength(0) * matrix.GetLength(1)) // Общее кол-во элементов массива
{
  matrix[i, j] = temp; //Присваиваем значение, пока выполняется условие цикла
  temp++;

  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)  // Условия для перемещения спиралью по индексам матрицы
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;   
  else
    i--;
}

// Метод для вывода результата в консоль

void PrintMatrix (int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintMatrix(matrix);