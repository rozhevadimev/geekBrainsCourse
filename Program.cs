// Задание 4_3: Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Please, Enter number");

int number = int.Parse(Console.ReadLine ()!);

//Cubes of even numbers also end with an even digit

int count = 0;

Console.WriteLine($" {count}");

while (count < number-1)

{
 
count += 2;
    
Console.WriteLine($"number {count}");

Console.WriteLine($"cube of number" + Math.Pow(count, 3)); 

 }
