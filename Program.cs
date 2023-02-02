// задание 13
Console.WriteLine("Please, Enter number");
int number = int.Parse(Console.ReadLine ()!);

dynamic f(int n) 
{
    if (n < 100) {
        return "no third digit";
    }
    return int.Parse(n.ToString().Substring(2, 1));
}
Console.WriteLine(f(number));
