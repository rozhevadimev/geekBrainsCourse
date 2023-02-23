// Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
Console.WriteLine("Enter how many rows the 2D array will have:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter how many columns the 2D array will have:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToDouble(rnd.Next(-2, 10)/20.0);}}}
FillArray(twoDimArray);
Console.WriteLine();
Console.WriteLine("New 2D array: ");
PrintArray(twoDimArray);
Console.WriteLine();
Console.WriteLine("Enter the coordinates of the element of the array");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("There is no number with such coordinates!");
 else
 {
 object c = twoDimArray.GetValue(a,b);
 Console.WriteLine(c);
 }
