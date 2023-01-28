// Решить задачу на входе число на выходе чётные числа от 1 до N

Console.Clear();

Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine()!);
int k = 1;

while(k<= N)
{
  if(k % 2==0)
  {
    Console.Write($"{k} ");
  }
  k++;
} 

