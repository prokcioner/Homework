/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] generateMat(int rows, int cols, int min, int max)
{
  Random random = new Random();
  int[,] array = new int[rows, cols];
  for (int i = 0; i < rows; i++)
  {
   for (int j = 0; j < cols; j++)
   {
    array[i, j] = random.Next(min, max + 1);
   } 
  }
return array;
}


void printMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + "| ");

    }
    Console.WriteLine(" ");
  }
}


Console.Write("Введите номер ряда: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите номер колонки: ");
int col = int.Parse(Console.ReadLine());


int[,] array = generateMat(4, 4, -10, 100);
printMatrix(array);

if (row > array.GetLength(0) || col > array.GetLength(1))
{
  Console.WriteLine("Такого элемента нет в массиве");
  Environment.Exit(0);
}

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    if (array[row - 1, col - 1] == array[i, j])
    {
    
      Console.WriteLine($"Такой элемент есть в массиве и он равен {array[row - 1, col - 1 ]}");
      
    }
  }
}