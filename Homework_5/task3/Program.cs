/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] newArray(int size, double min, double max) 
{
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
  array[i] = new Random().NextDouble() * (max - min) + min;
}

for (int i = 0; i < array.Length; i++)
{
  array[i] = Math.Round(array[i], 2);
}

return array;
}
void printArray(double[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
  Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[array.Length - 1]}.");
}

double DivMaxMin(double[] array)
{
  double max = -1;
  double min = -1;
for (int i = 0; i < array.Length; i++)
{
  if (max < array[i])
  {
    max = array[i];
  }
  
  if (min > array[i])
  {
    min = array[i];
  }
}

double result = max - min; 
return result;
}




double[] array = newArray(10, 0.0, 100.0);

printArray(array);

Console.WriteLine($"Разница между максимальным и минимальным значением равна: {DivMaxMin(array)}");




