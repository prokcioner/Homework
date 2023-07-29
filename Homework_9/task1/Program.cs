/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/




void Numb(int N)
{
  
  if (N == 0){System.Console.WriteLine(" ");  }
  else
  {
    System.Console.Write($"{N} ");
    Numb(N-1);
    
  }

}

System.Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Numb(n);
