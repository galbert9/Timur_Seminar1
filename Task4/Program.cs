﻿// Сравнить три числа и выбрать наибольшее
Console.WriteLine("Введите первое число");  
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число"); 
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите третье число"); 
int c = Convert.ToInt32 (Console.ReadLine());

if (a > b & a > c) Console.WriteLine("Max " +a);
else if (c > b) Console.WriteLine("Max " +c);
else Console.WriteLine("Max " +b);


    

