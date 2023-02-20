/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

int num;

Console.Write($"Введите трёхзначное число: ");
int.TryParse(Console.ReadLine()!, out num);

int secondNum = num / 10 % 10;

Console.Write($"Вторая цифра числа: {secondNum}"); */



/* Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.

int num;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);

int num2 = Math.Abs(num);

if (num2 > 99)
{
    while (num2 > 999)
        num2 /= 10;
    Console.Write($"{num2 % 10}");
}
else
    Console.Write($"Третьей цифры нет"); */



/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

int num;
Console.Write($"Введите день недели: ");
int.TryParse(Console.ReadLine()!, out num);

switch (num)
{
    case 6:
    case 7:
        Console.Write("Выходной день");
        break;
    default:
        Console.Write("Будний день");
        break;
} */