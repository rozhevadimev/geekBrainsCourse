// задание 15
Console.WriteLine("Please, Enter number");
int number = int.Parse(Console.ReadLine ()!);

string f(int day) {
    bool isWeekend = day == 6 || day == 7;
    return isWeekend ? "Да" : "Нет";
}
Console.WriteLine(f(number));
