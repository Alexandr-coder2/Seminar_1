// Решить задачу на три числа, узнать какое больше

Console.Clear();

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c ");
int c = int.Parse(Console.ReadLine()!);
int max = 0;
if (max < a)
{
    max = a;
}
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"{max}");
