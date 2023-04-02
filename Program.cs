//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int num1 = num / 10;
int num2 = num1 % 10;
Console.WriteLine(num2);



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num >= 100)
{
    int num1 = num % 10;
    Console.WriteLine(num1); 
}

else 

{
    Console.Write("Третьей цифры нет");
}




//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 6)
{
    Console.WriteLine("Рабочий день :( ");
} 
else if (num == 6)
{
    Console.WriteLine("Суббота, выходной :) ");
}
else if (num == 7)
{
    Console.WriteLine("Восресенье, выходной :) ");
}
