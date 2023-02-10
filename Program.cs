// Задание 4_2: Написать программу вычисления произведения чисел от 1 до N 

Console.WriteLine("Please, Enter number");

int number = int.Parse(Console.ReadLine ()!);

int count = 1;

int product = 1;

while (count <= number)

{
 product *= count;

Console.WriteLine($"multiplication of number {count} - number {product}"); 

count += 1;
 }
