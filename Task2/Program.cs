﻿// Сравнить два числа и найти большее 
Console.WriteLine("Введите первое число");  
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число"); 
int b = Convert.ToInt32 (Console.ReadLine());
if(a > b)
{
    Console.WriteLine("Max " +a);
}
else
{
    Console.WriteLine("Max " +b);
}