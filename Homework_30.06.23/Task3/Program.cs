// Задача 23

int cube(int number)
{
  number = number*number*number;
  return number;
}


Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
  Console.Write($"{cube(i)} ");
}