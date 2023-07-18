/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] createArray(int row, int col, int min, int max)
{
int[,] array = new int[row, col];
Random random = new Random();
for (int i = 0; i < row; i++)
{
  for (int j = 0; j < col; j++)
  {
    array[i, j] = random.Next(min, max + 1);
  }
}
return array;
}
void printArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    Console.Write(array[i, j] + " ");
  }
Console.WriteLine();
}
}

int minRow(int[,] array)
{
int[] array2 = new int[array.GetLength(0)];
int count = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
  int sum = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    sum = sum + array[i, j];
  }
  array2[count] = sum;
  count++;
}

int min = array2[0];
for (int k = 1; k < array2.Length; k++)
{
  if (min > array2[k])
  {
    min = array2[k];
  }
}

int row = Array.IndexOf(array2, min);
int result = row + 1;
return result;
}

int [,] matrix = createArray(4,4,1,9);
printArray(matrix);
Console.WriteLine("");
Console.WriteLine($"Минимальная строчка под номером: {minRow(matrix)} ");






