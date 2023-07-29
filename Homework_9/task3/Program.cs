/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Accerman(int m, int n)
{
int answer = 0;
if (m == 0)
{
  answer = n + 1;
}
else if (m > 0 && n == 0)
{
  return Accerman(m-1, 1); 
}
else if (m>0 && n>0)
{
  return Accerman(m-1,Accerman(m, n-1));
}
return answer;
}
System.Console.Write("Введите первое число, m = ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите второе число, n = ");
int n = int.Parse(Console.ReadLine());
int result = Accerman(m, n);
System.Console.WriteLine($"Ответ:{result} ");