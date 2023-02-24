//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
Console.Clear();
int m = InputNumbers("Enter quantity of colums m: ");
int n = InputNumbers("Ente quntity of rows n: ");
int range = InputNumbers("Enter a range of numbers: from 1 to ");
int[,] twoDimArray = new int[m, n];
CreateArray(twoDimArray);
WriteArray(twoDimArray);
Console.WriteLine($"\n Descending sorted array: ");
OrderArrayLines(twoDimArray);
WriteArray(twoDimArray);
void OrderArrayLines(int[,] twoDimArray)
{
  for (int i = 0; i < twoDimArray.GetLength(0); i++)
  {
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
      for (int k = 0; k < twoDimArray.GetLength(1) - 1; k++)
      {
        if (twoDimArray[i, k] < twoDimArray[i, k + 1])
        {
          int temp = twoDimArray[i, k + 1];
          twoDimArray[i, k + 1] = twoDimArray[i, k];
          twoDimArray[i, k] = temp;
        }
      }
    }
  }
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] twoDimArray)
{
  for (int i = 0; i < twoDimArray.GetLength(0); i++)
  {
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
      twoDimArray[i, j] = new Random().Next(range);
    }
  }
}
void WriteArray(int[,] twoDimArray)
{
  for (int i = 0; i < twoDimArray.GetLength(0); i++)
  {
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
      Console.Write(twoDimArray[i, j] + " ");
    }
    Console.WriteLine();
  }
}
