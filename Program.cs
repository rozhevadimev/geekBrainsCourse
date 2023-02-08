// Задание19
{
            int number, r, sum = 0, t;
            Console.Write("Enter a five-digit number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (t = number; number != 0; number = number / 10)
            {
                r = number % 10;
                sum = sum * 10 + r;
            }

            if (t == sum)
                Console.Write("{0} is a palindrome number.\n", t);

            else
                Console.Write("{0} is not a palindrome number.\n", t);
        }
