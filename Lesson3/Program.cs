/* Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом. */
/*
Console.Write("Введите число: ");
string num = Console.ReadLine()!;
int len = num.Length;

if (len == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
        Console.Write($"{num} - палиндром");
    else
        Console.Write($"{num} - не является палиндромом");
}
else
    Console.Write($"{num} - не является пятизначным"); */


/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве. */
/*
double[] A = new double[3];
double[] B = new double[3];

Console.Write($"Введите координату X точки А: ");
double.TryParse(Console.ReadLine()!, out A[0]);
Console.Write($"Введите координату Y точки А: ");
double.TryParse(Console.ReadLine()!, out A[1]);
Console.Write($"Введите координату Z точки А: ");
double.TryParse(Console.ReadLine()!, out A[2]);
Console.Write($"Введите координату Х точки В: ");
double.TryParse(Console.ReadLine()!, out B[0]);
Console.Write($"Введите координату Y точки В: ");
double.TryParse(Console.ReadLine()!, out B[1]);
Console.Write($"Введите координату Z точки B: ");
double.TryParse(Console.ReadLine()!, out B[2]);

double AB = Math.Round(Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2) + Math.Pow((B[2] - A[2]), 2)), 2);

Console.Write($"Расстояние между точками равно {AB}"); */


/*Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N. */
/*
int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

for (int i = 1; i <= N; i++)
    Console.Write($"{i * i * i}, "); */