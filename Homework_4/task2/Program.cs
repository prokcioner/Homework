/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/* int sum(int num)
{
int sum = 0;
int remains = num;
while (remains > 0)
{
  remains = num % 10;
  sum = sum + remains;
  num = num /10;
}
return sum;
}


Console.Write("Введите цисло: ");
int numb = int.Parse(Console.ReadLine());
int result = sum(numb);
Console.WriteLine($"Сумма цифр в числе равна: {result}");*/

Console.Write("Введите цисло: ");
string numb = Console.ReadLine();

int sum = 0;

for (int i = 0; i <= numb.Length - 1; i++)
{
  sum = sum + int.Parse(numb[i].ToString());
}

Console.WriteLine($"Сумма цифр в числе равна: {sum}");