// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее. 

Console.WriteLine("Введите число 1 -> ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 -> ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.Write(num1);
}
else
{
     Console.Write(num2);
}

