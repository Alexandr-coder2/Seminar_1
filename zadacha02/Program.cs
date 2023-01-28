// Решить задачу два числа узнать какое больше

Console.Clear();

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);
int max = a;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.WriteLine($"{max}");
