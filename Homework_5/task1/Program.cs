/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] newArray(int size, int min, int max) 
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
  array[i] = new Random().Next(min, max);
}
return array;
}
void printArray(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
  Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[array.Length - 1]}.");
}

int evenNum(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] % 2 == 0)
  {
    count++;
  }
}
return count;
}

int[] array = newArray(10, 100, 999);
printArray(array);
Console.WriteLine($"Чётных цифр в массиве: {evenNum(array)}");


