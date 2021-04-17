using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //* 1. Дано 15 цифр. Найти среднеарифметическое четных чисел.
            int[] numbersArr = new int[15];
            string input;
            int count = 0;
            int amountEvenNumbers = 0;
            for (int i = 0; i < numbersArr.Length; i++)
            {
                Console.Write($"Введите число №{i + 1}: ");
                input = Console.ReadLine();
                numbersArr[i] = int.Parse(input);
            }

            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] % 2 == 0)
                {
                    amountEvenNumbers += numbersArr[i];
                    count++;
                }
            }

            Console.WriteLine($"Среднее арифметическое четных чисел = {amountEvenNumbers / count}");

            //* 2. Написать программу которая выводит на экран только отрицательные числа. 
            //*Вводятся как положительные так и отрицательные числа.
            numbersArr = new int[15];
            for (int i = 0; i < numbersArr.Length; i++)
            {
                Console.Write($"Введите число №{i + 1}: ");
                input = Console.ReadLine();
                numbersArr[i] = int.Parse(input);
            }

            for (int i = 0; i < numbersArr.Length; i++)
            {
                if ( numbersArr[i] < 0)
                {
                    Console.WriteLine($"{numbersArr[i]}");
                }
            }

            //* 3. Плотность воздуха убывает с высотой по закону p=p0*exp((-h*z)*ln(e)), 
            //*где p - плотность на высоте h метров, p0=1,29 кг/м, z=mg/rt=1.25*exp(-4*ln(10)). 
            //*Напечатать таблицу зависимости плотности от высоты для значений от 0 до 1000м 
            //*через каждые 100м.

            double airDensity = 0;
            double airDensity0 = 1.29;
            double z = 1.25 * Math.Exp(Math.Pow(Math.E, -4) * Math.Log(10, Math.E));

            for (int h = 0; h <= 1000; h += 100)
            {
                airDensity = airDensity0 * Math.Exp((-h * z) * Math.Log(Math.E, Math.E));
                //Console.WriteLine($"Давление на высоте {h} = {Math.Round(airDensity, 4)}");
                Console.WriteLine($"Давление на высоте {h} = {airDensity}");
            }

            Console.WriteLine($"{Math.Log(Math.E, Math.E)}");
            Console.WriteLine($"{z}");
        }
    }
}
