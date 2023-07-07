/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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

int sum(int[] array)
{
  int result = 0; 
  for (int i = 1; i < array.Length; i = i + 2)
  {
    result += array[i];
  }

return result;
}

int[] array = newArray(5, 1, 5);
printArray(array);
Console.WriteLine($"Ответ: {sum(array)}");


