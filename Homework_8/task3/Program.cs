/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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
int[,] multMatrix(int[,] matrix1, int[,] matrix2)
{
int[,] multMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
  for (int j = 0; j < matrix2.GetLength(1); j++)
  {
    int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i, k] * matrix2[k, j];
      }
    multMatrix[i, j] = sum;
  }
}
return multMatrix;
}

int[,] array1 = createArray(2,2,1,9);
printArray(array1);
Console.WriteLine();
int[,] array2 = createArray(2,2,1,9);
printArray(array2);
Console.WriteLine();
int[,] array3 = multMatrix(array1,array2);
printArray(array3);





