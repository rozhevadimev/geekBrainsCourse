/ Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
 Console.Clear();
Random random = new Random();
int[,] twoDimArray = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < twoDimArray.GetLength(0); i++)
{
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
       twoDimArray[i, j] = random.Next(1, 10);
        Console.Write(twoDimArray[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
Console.WriteLine(twoDimArray.GetLength(0));
for (int j = 0; j < twoDimArray.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        sum += twoDimArray[i, j];
    }
    Console.Write($"{ sum / twoDimArray.GetLength(0)} ");
}
Console.ReadLine();
