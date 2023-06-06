// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели"); 
{
int num1 = Convert.ToInt32( Console.ReadLine() );  
if (num1 == 1) 
Console.WriteLine("Начинаем работать");
else if (num1 == 2)
Console.WriteLine("Продолжаем работать"); 
else if (num1 == 3) 
Console.WriteLine("Продолжаем работать"); 
else if (num1 == 4) 
Console.WriteLine("Продолжаем работать"); 
else if (num1 == 5) 
Console.WriteLine("Продолжаем работать"); 
else if (num1 == 6) 
Console.WriteLine("Сегодня выходной"); 
else if(num1 == 7) 
Console.WriteLine("Сегодня выходной");
else
Console.WriteLine("Введите число от 1 до 7");
}

