// Выбрать четные числа
Console.WriteLine("Ввести число");
int x = Convert.ToInt32 (Console.ReadLine());
int i = -x;
while (i <= x)
{
   if (i > 0 & i % 2 == 0)
   Console.Write(i + " ");
   i = i + 1; 
}
   



