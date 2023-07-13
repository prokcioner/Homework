/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] generateMat(int row, int col, int min, int max)
{
  Random random = new Random();
  int[,] mat = new int[row, col];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      mat[i, j] = random.Next(min, max + 1);
    }
  }
return mat;
}
void printMatr(int[,] mat)
{
  for (int i = 0; i < mat.GetLength(0); i++)
  {
    for (int j = 0; j < mat.GetLength(1); j++)
    {
      Console.Write(mat[i, j] + "|");
    
    }
    Console.WriteLine(" ");
  }
}

double[] avarage(int[,] mat)
{
double[] colAvarage = new double[mat.GetLength(1)];
double sum = 0;
for (int i = 0; i < mat.GetLength(1); i++)
{
  sum = 0;
  for (int j = 0; j < mat.GetLength(0); j++)
  {
    sum= sum + mat[j, i];
  }
  colAvarage[i] = sum / mat.GetLength(0);
}
return colAvarage;
}
void printArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + "| ");
  }
}


int[,] matrix = generateMat(2, 3, 1, 100);
printMatr(matrix);
Console.WriteLine(" ");
double[] avarageCol = avarage(matrix);
printArray(avarageCol); 

