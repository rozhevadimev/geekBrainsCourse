Console.WriteLine("Please, Enter number");
int number = int.Parse(Console.ReadLine ()!);
// задание 10
int f(int n) 
{
    return int.Parse(n.ToString().Substring(1, 1));
}
Console.WriteLine(f(number));