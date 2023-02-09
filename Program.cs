Задание 23-1

int num;

Console.Write("Enter nimber: ");

num = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Your number: " + num);
 
Console.Read();
       
Console.WriteLine("Number\tcube number");

for (int i = 0; i <= num; i++)

{Console.WriteLine("{0}\t{1}", i, Math.Pow(i,3));

}
