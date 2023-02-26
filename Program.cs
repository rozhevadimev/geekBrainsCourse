//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
SumFromMToN(m, n);
void SumFromMToN(int m, int n)
{
    Console.WriteLine(SumMN(m - 1, n));
}
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
