// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine( "Please enter the required data to calculate the point of intersection of two lines");
Console.WriteLine("Enter k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
if ((k1 * b2 - k2 * b1) == 0) 
    Console.WriteLine($"Straight lines are parallel)");

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine($"The intersection is at: ({x};{y})");
