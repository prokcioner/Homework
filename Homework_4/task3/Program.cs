/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Hello, World!");



int[] array = new int[8];
      
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(1, 99);
}

for (int i = 0; i < array.Length; i++)
{
  Console.Write($"{array[i]} ");
}