/* Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные 
числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int Promt(string msg)
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine());
}
void ShowNumbers(int start, int finish)
{
    if (start > finish || start < 0)
    {
        return;
    }
    if (start % 2 > 0)
    {
        start = start + 1;
    }
    System.Console.Write($"{start}; ");
    ShowNumbers(start + 2, finish);
}

int M = Promt("Введите число M");
int N = Promt("Введите число N");
ShowNumbers(M, N);


