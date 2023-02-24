// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.;
Console.Clear();
int m = InputNumbers("Enter the number of rows of the 1st matrix: ");
int n = InputNumbers("Enter the number of columns of the 1st matrix (and rows of the 2nd matrix): ");
int p = InputNumbers("ВEnter the number of columns of the 2nd matrix: ");
int range = InputNumbers("Enter a range of random numbers: from 1 to ");
int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"First matrix: ");
WriteArray(firstMartrix);
int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Second matrix: ");
WriteArray(secomdMartrix);
int[,] resultMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Multiplication of the first and second matrices: ");
WriteArray(resultMatrix);
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
