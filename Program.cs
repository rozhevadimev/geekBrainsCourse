// Задание 4_1 Сумма цифр числа

 Console.Write("Number = ");

        var n = Convert.ToInt32(Console.ReadLine());

        var sum = 0;

        while(n > 0)
        {
            sum += n % 10;
         
            n /= 10;
        }

        Console.WriteLine($"The sum of the digits of the number is {sum}");
