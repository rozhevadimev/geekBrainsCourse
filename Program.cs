// Задание 23

Console.WriteLine("Please, Enter number");
int number = int.Parse(Console.ReadLine ()!);

int count = 0;
Console.WriteLine($" {count}");

while (count < number)

{
    
count += 1;
Console.WriteLine($"number {count}");
//
Console.WriteLine($"cube of number" + Math.Pow(count, 3)); 

 }
