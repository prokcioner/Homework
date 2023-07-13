﻿/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9    */

double[,] generateMatrix(int row, int col, double min, double max)
{
  Random random = new Random();
  double[,] array = new double[row, col];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      array[i,j] = Math.Round(random.NextDouble() * (max - min) + min, 1);
    }


  }
return array;
}
void printMatrix(double[,] matrix)
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


double[,] array = generateMatrix(3, 4, -10.0, 10.0);

printMatrix(array);



