/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
int Promt(string message)
{
  Console.Write(message);
  int result = int.Parse(Console.ReadLine());
  return result;
}
void printArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}
int positiveNum(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      count++;
    }
  }
return count;
}


int length = Promt("Напишите сколько чисел вы хотите ввести: ");
int[] array = new int[length];
int num = 0;
for (int i = 0; i < array.Length; i++)
{
  array[i] = Promt($"Введите {i + 1} число: ");
}
Console.WriteLine($"Пользователь ввёл {positiveNum(array)} чисел больше нуля");








printArray(array); 


