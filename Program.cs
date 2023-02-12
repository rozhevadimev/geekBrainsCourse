// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
return result;
}
int Result(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if(a[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}
int[] array  = GetArray(13, 100, 999);
Console.WriteLine(String.Join(", ", array));
int count = Result(array);
Console.WriteLine($"Quantity of even number:{count}");
