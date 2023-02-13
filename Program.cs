// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива
Console.WriteLine("Please enter the size of the array:");
int n = Convert.ToInt32(Console.ReadLine());
int [] mass  = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
    { mass[i] = rnd.Next(-50, 50);
    Console.Write($" {mass[i]} ");
}
int min = 0;
int max = 0;
foreach (int i in mass)  // Ищу максимальное и минимальное значения
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"\n Maximum array element: {max}\n Minimum array element: {min}");
Console.WriteLine($"Difference between maximum and minimum element: {max-min}");
