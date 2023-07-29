/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sum(int a, int b)
{
if (b < a){return 0;}
else
{
  return a + sum(a + 1, b);
}
}

System.Console.Write("Введите первое число: ");
int firstN = int.Parse(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int secondN = int.Parse(Console.ReadLine());

Console.WriteLine($"Ответ: {sum(firstN, secondN)}");
