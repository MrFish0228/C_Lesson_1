//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1, num2, num3;
int max;
Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out num2);
Console.Write($"Введите третье число: ");
int.TryParse(Console.ReadLine()!, out num3);

max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max= num3;
}

Console.Write($"Максимальное число: " + max);