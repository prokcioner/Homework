/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
void sortArray(int[,] array)
{
int temp  = -1;

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
   for (int k = 0; k < array.GetLength(1); k++)
   {
    if (array[i, j] > array[i, k])
    {
      temp = array[i, j];
      array[i, j] = array[i, k];
      array[i, k] = temp;
    }
   }
  }
}

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


int[,] array = createArray(5, 5, 1, 100);

printArray(array);

Console.WriteLine(" ");

sortArray(array);

printArray(array);



