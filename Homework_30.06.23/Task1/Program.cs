// Задача 19

int Palindrome(int number)
{
  int originalNumber = number;
  int reverseNumber = 0;
  while (number > 0)
  {
    int remains = number % 10;
    reverseNumber = (reverseNumber * 10) + remains;
    number = number / 10;
  }
  return reverseNumber;
}

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99999 || number < 10000)
{
  Console.WriteLine("Введите пятизначное число!!!!");
  return;
}
int reverseNumber = Palindrome(number);
if (number == reverseNumber)
{
  Console.WriteLine("Введенное число палиндром");
}
else
{
  Console.WriteLine("Введенное число не является палиндромом");
}