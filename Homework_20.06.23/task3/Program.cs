//Задача 3: Напишите программу, которая принимает на вход цифру, обозначащую день
//недели, и проверяет, является ли этот дени выходным.

Console.Write("Введите число ");
int day = int.Parse(Console.ReadLine());

switch (day)
{
  case (1):
    Console.Write("Рабочий день");
    break;
  case (2):
    Console.Write("Рабочий день");
    break;
  case (3):
    Console.Write("Рабочий день");
    break;
  case (4):
    Console.Write("Рабочий день");
    break;
  case (5):
    Console.Write("Рабочий день");
    break;
  case (6):
    Console.Write("Выходной день");
    break;
  case (7):
    Console.Write("Выходной день");
    break;
  
  default:
  Console.Write("Введите число от 1 до 7");
  break;
}