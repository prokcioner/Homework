//Задача 2: Напишите программу, которая выводит третью цифру заданного
//числа или сообщает, что третьей цифры нет.

Console.Write("Введите трёхзначное число ");
int numb = int.Parse(Console.ReadLine());
int thirdNumb = numb%10;



if (numb < 100)
{
  Console.WriteLine($"Напишите третью цифру");
}
else
{
Console.WriteLine($"Третья цифра в заданном числе равна {thirdNumb} ");
}