using System;

namespace Фибоначчи
{
    class Lesson1_1
    {
        public static void Algorithm(int number)
        {
            
            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                    i++;
                }
                if (d == 0)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число не простое");
                }
            break;

            }
        }
    }
    class Lesson1_3
    {
        public static void GetFibonachchiRecursiya(int x, int y, int i, int Ui)
        {
            //метод Фибоначчи через рекурсию
            i++;
            int z = x + y;
            x = y;
            y = z;
            if (i > Ui)
            {
                return;
            }
            Console.WriteLine(z);
            GetFibonachchiRecursiya(x, y, i, Ui);
        }

        public static void GetFibonachchiCycle(int en)
        {
            //Метод Фибоначчи через цикл
            int x = 0;
            int y = 1;
            for (int h = 0; h < en; h++)
            {
                int z = x + y;
                x = y;
                y = z;
                Console.WriteLine(z);
            }
        }
    }
    class Program
    {

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания, которое вы хотите запустить \nнапример 3");
                string UserEnterNumber = Console.ReadLine();
                if (UserEnterNumber == "1")
                {
                    Console.WriteLine("Введите число ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Lesson1_1.Algorithm(number);
                }
                if (UserEnterNumber == "3")
                {
                    Console.WriteLine("Метод через рекурсию" + "\n" + "Укажите количество количество элементов формируемой последовательности");
                    int NumberofIterations = Convert.ToInt32(Console.ReadLine());
                    Lesson1_3.GetFibonachchiCycle(NumberofIterations);
                    Console.WriteLine("Метод через цикл" + "\n" + "Укажите количество количество элементов формируемой последовательности");
                    NumberofIterations = Convert.ToInt32(Console.ReadLine());
                    Lesson1_3.GetFibonachchiRecursiya(0, 1, 0, NumberofIterations);

                }
                if (UserEnterNumber == "2")
                {
                    Console.WriteLine("Ответ (n^3), так как остальные константы в выражении отбрасываются"); //Я не создавал отдельный класс и метод, т к это не имеет смысла
                }
            }
        }

    }
}

