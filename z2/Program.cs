/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите первое число > ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число > ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum()
{
int sum=0;
for (int i=M; i<=N; i++)
{
    sum=sum+i;
}
return sum;
}

int AlgSum=Sum();
Console.WriteLine($"Сумма натуральных элементов от  {M} до {N} равна {AlgSum}");