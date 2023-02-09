// Задание 21
Console.WriteLine("Enter point coordinates:");
int x1 = Coordinate("x1", ":First coordinate of point 1");
int y1 = Coordinate("x2", ":Second coordinate of point 1");
int z1 = Coordinate("x3", ":Third coordinate of point 1");
int x2 = Coordinate("y1", ":First coordinate of point 2");
int y2 = Coordinate("y2", ":Second coordinate of point 2");
int z2 = Coordinate("y3", ":Third coordinate of point 2");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Enter coordinate {coorName} of point {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
                {
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"The length of the segment in 3D space  {segmentLength}");
