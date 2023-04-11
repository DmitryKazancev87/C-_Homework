// 1. Программа, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine(" Введите первое число ");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine(" Введите второе число ");
int b = int.Parse (Console.ReadLine()!);
if (a > b) {
Console.WriteLine(" Максимальное число ");
Console.WriteLine(a);
Console.WriteLine(" Минимальное число ");
Console.WriteLine(b);}
else if (a < b) {
Console.WriteLine(" Максимальное число ");
Console.WriteLine(b);
Console.WriteLine(" Минимальное число ");
Console.WriteLine(a);
}
else {
Console.WriteLine(" Числа равны, введите новые числа");
}