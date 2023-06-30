/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int square(int num, int N)
{
  int square = num;
   for (int i = 1; i < N; i++)
 {
  square = square * num;
  
 }

return square;
}

Console.Write("Введите число которое хотите возвести в степень: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите степень в которую будте возводить число: ");
int num2 = int.Parse(Console.ReadLine());

int result = square(num1, num2);

Console.WriteLine($"Ответ: {result}");