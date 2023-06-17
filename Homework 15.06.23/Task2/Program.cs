//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());

  int max = 0;
  int min = 0;

if (a>b)
{
  max = a;
  min = b;
}
else
{
  max = b;
  min = a;
}

if (a == b)
{
Console.WriteLine($"Число {max} равно числу {min}.");  
}
else
{
Console.WriteLine($"Число {max}, больше чем {min}.");  
}
