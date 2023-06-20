//Задача 1: Напишите программу, которая принимает на выход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число ");
int numb = int.Parse(Console.ReadLine());
int secondNumb = (numb/10%10);
Console.WriteLine($"Второе число заданной цифры равно {secondNumb}");
