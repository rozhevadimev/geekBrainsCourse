//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
Console.WriteLine("Enter quntity of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter quntity of colums: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] twoDimArray)
{
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimArray.GetLength(1); j++)
        {
            twoDimArray[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] twoDimArray)
{
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
               for (int j = 0; j < twoDimArray.GetLength(1); j++)
        {
            Console.Write(twoDimArray[i, j] + " ");
        }
                Console.WriteLine("");
    }
}
