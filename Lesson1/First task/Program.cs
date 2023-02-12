//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num1, num2;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out num2);

if (num1 > num2)
{
    Console.Write($"Максимальное число: " + num1);
}
else
{
    Console.Write($"Максимальное число: " + num2);
}