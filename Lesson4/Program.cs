/* Напишите цикл, который принимает на вход два
числа (A и B) и возводит число A в натуральную степень B. */
/*
int A = add_num("Введите число А: ");
int B = add_num("Введите число B: ");

Console.Write($"{A}^{B} = {degree(A, B)}");

int add_num(string str = "Введите число: ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}

int degree(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}  */


/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */
/*
int num = add_num();
Console.Write($"{num} -> {sum(num)}");

int add_num(string str = "Введите число: ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}

int sum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
} */


/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */
/*
int max = add_num("Введите максимальное значение массива: ");
int min = add_num("Введите минимальное значение массива: ");
int[] Array = array(max, min);
print(Array);

int[] array(int max, int min)
{
    int[] array = new int[7];
    Random random = new Random();
    for (int i = 0; i < 7; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void print(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write($"]");
}

int add_num(string str = "Введите число: ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
} */