// 2. Программа, которая на вход принимает три числа и выдает, какое число максимальное из этих чисел.
Console.WriteLine(" Введите первое число ");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine(" Введите второе число ");
int b = int.Parse (Console.ReadLine()!);
Console.WriteLine(" Введите третье число ");
int c = int.Parse (Console.ReadLine()!);
int max = 0;
if ((a >= b) && (a >= c)) { 
    max = a;}
else if ((b>a) && (b>=c)) { 
    max = b;}
else if ((c>=a) && (c>b)) {
    max = c;}
else {    
Console.WriteLine(" Все числа равны, введите разные числа для сравнения ");
}    
Console.WriteLine(" Максимальное число ");
Console.WriteLine(max); 
 