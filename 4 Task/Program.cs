//4. Программа, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N. является ли число четным или нет.
Console.WriteLine(" Введите число ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.Write(i + " ");
