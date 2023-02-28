using System;
using System.Numerics;

namespace Workshop_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_3();
            Task_3();
            Task_3();
            Task_3();
        }
        /* Задано натуральне число. Скільки цифр є в його десятковому записі?
         * Запропонувати хоча б три способи визначення.
         */
        static void Task_1()
        {
            // Загальне схема введення числових значень
            Console.Write("Введіть натуральне число: ");
            uint number = uint.Parse(Console.ReadLine());
            int digits = number.ToString().Length;
            Console.WriteLine($"Число {number} має {digits} цифр.");

            int counter = 0;
            uint copy = number;
            while (copy > 0)
            {
                ++counter;
                copy /= 10;
            }
            Console.WriteLine($"Число {number} має {counter} цифр.");

            int formula = (int)Math.Log10(number) + 1;
            Console.WriteLine($"Число {number} має {formula} цифр.");
        }
        /* Ціна дрона фіксована. Волонтери зібрали money грошей.
         * Надрукуйте фразу "Ми купили k дронів", (k залежить від money)
         * узгоджуючи закінчення слів.
         */
        static void Task_2()
        {
            const Decimal price = 249.99M;
            Console.Write("Скільки зібрано грошей? ");
            Decimal money = Decimal.Parse(Console.ReadLine());
            int k = (int)(money / price);
            Console.WriteLine($" k = {k}");
            if (11 <= k && k <= 19)
            {
                Console.WriteLine($"Ми купили {k} дронів.");
                return;
            }
            switch (k % 10)
            {
                case 1:
                    Console.WriteLine($"Ми купили {k} дрон."); break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine($"Ми купили {k} дрони."); break;
                default:
                    Console.WriteLine($"Ми купили {k} дронів."); break;
            }
        }
        /* Задано натуральне n. Обчислити f_n - n-те число Фібоначчі
         * f_0 = f_1 = 1; f_k = f_(k-1) + f_(k-2), k = 2, 3, ...
         */
        static void Task_3()
        {
            Console.Write("Введіть натуральне число: ");
            uint n = uint.Parse(Console.ReadLine());
            BigInteger a = 1, b = 1;
            BigInteger c;
            for (uint k = 2; k <= n; ++k)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine($" f_{n} = {b}");
        }
        /* Задано три дійсні числа. Знайдіть значення найбільшого з них.
         * Запропонуйте хоча б п'ять способів.
         */
        static void Task_4()
        {
        }
    }
}
