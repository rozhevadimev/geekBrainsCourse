//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
 static class MatrixExt
{
        public static int RowsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(0) + 1;
    }
 public static int ColumnsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(1) + 1;
    }   
        static int[,] GetMatrixFromConsole(string name)
    {
        Console.Write("Quantity of rows of matrix {0}:    ", name);
        var n = int.Parse(Console.ReadLine());
        Console.Write("Quantity of colums of matrix {0}: ", name);
        var m = int.Parse(Console.ReadLine());
 
        var matrix = new int[n, m];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                Console.Write("{0}[{1},{2}] = ", name, i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
 
        return matrix;
    }
     static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.RowsCount(); i++)
        {
            for (var j = 0; j < matrix.ColumnsCount(); j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }
 
            Console.WriteLine();
        }
    }
     static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.ColumnsCount() != matrixB.RowsCount())
        {
            Console.WriteLine("Multiplication is impossible! The number of columns in the first matrix is not equal to the number of rows in the second matrix.");
                }
        var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];
         for (var i = 0; i < matrixA.RowsCount(); i++)
        {
            for (var j = 0; j < matrixB.ColumnsCount(); j++)
            {
                matrixC[i, j] = 0;
                 for (var k = 0; k < matrixA.ColumnsCount(); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
         return matrixC;
    }
     static void Main(string[] args)
    {
        Console.WriteLine("Program of Matrix Multiplication");
 
        var a = GetMatrixFromConsole("A");
        var b = GetMatrixFromConsole("B");
 
        Console.WriteLine("Matrix A:");
        PrintMatrix(a);
 
        Console.WriteLine("Matrix B:");
        PrintMatrix(b);
 if (a.ColumnsCount() != b.RowsCount())

  Console.WriteLine("Multiplication is impossible!");
else
        MatrixMultiplication(a, b);
        Console.WriteLine("Matrix multiplication:");
        PrintMatrix(MatrixMultiplication(a, b));
 
        Console.ReadLine();
    }
}
