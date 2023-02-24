//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int n1, n2;
            int[,] A;
             Console.Write("Enter the number of rows in the matrix: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of colums in the matrix: ");
            n2 = int.Parse(Console.ReadLine());
            A = new int[n1, n2];
            Random rnd = new Random();
 
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < n2; j++)
                    A[i, j] = rnd.Next(-0, 10 + 1);
 
                        for (int i = 0; i < n1; i++, Console.WriteLine())
                for (int j = 0; j < n2; j++)
                    Console.Write(A[i, j] + "\t");
int minRowSum = int.MaxValue, indexMinRow = 0;
 
             for (int i = 0; i < n1; i++)
             {
                int rowSum = 0;
                for (int j = 0; j < n2; j++)
                    rowSum += A[i, j];
                                if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    indexMinRow = i;
                }
             }
              Console.WriteLine("Row with minimum sum of matrix elements");
                 for(int j = 0;j<n2;j++)
                      Console.Write(A[indexMinRow, j] + "\t");
