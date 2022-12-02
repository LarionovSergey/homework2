Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a / b == b | b / a == a)
{
    Console.WriteLine ("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Одно число не является квадратом другого");
}
