// Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 8
//что такого элемента нет.
Console.WriteLine("Enter the coordinate of the array row");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinate of the array column");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [6,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("There is no number with such coordinates!");
}
else
{
    Console.WriteLine($"The value {n} of the row and column {m} of the array is  {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] twoDimArray)
{
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
        {        
            for (int j = 0; j < twoDimArray.GetLength(1); j++)
            {
                twoDimArray [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] twoDimArray)
{
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < twoDimArray.GetLength(1); j++)
        {
            Console.Write(twoDimArray[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
