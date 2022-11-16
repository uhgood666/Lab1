using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab9
{
    class Program
    {
      
        private static object number;
        private static int persent;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int a, b;
                string c;

                try
                {
                    // Ввод первого числа
                    Console.Write("Введите целое число х=");
                    a = Convert.ToInt32(Console.ReadLine());

                    // Ввод второго числа
                    Console.Write("Введите целое число y=");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    Console.ReadLine();
                    continue;
                }

                // Выбор операции 
                Console.Write("Введите код операции: \n\t + сложение \n\t - вычитание\n\t * умножение\n\t / частное\n         ^ степень\n\t % процент\n\t ");
                c = Console.ReadLine();
                switch (c)
                {
                    // Выполнение сложения
                    case "+":
                        Console.WriteLine("Сумма чисел {0} и {1} равна {2}", a, b, a + b);
                        break;

                    // Выполнение вычитания
                    case "-":
                        Console.WriteLine("Разность чисел {0} и {1} равна {2}", a, b, a - b);
                        break;

                    // Выполнение умножения
                    case "*":
                        Console.WriteLine("Произведение чисел {0} и {1} равно {2}", a, b, a * b);
                        break;

                    // Выполнение возведения в степень
                    case "^":
                        Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(a, b));
                        Console.ReadKey();
                        break;

                    // Выполнение процентов
                    case "%":
                        int d = a % b ;
                        Console.WriteLine("Результат подчсчета процентов число = {0}, ", d);
                        double result = a * b/100;
                        Console.ReadLine();
                        break;

                    // Выполнение деления
                    case "/":
                        try
                        {
                            Console.WriteLine("Частное чисел {0} и {1} равно {2}", a, b, a / b);
                        }
                        catch (DivideByZeroException) when (a == b && b == 0)
                        {
                            Console.WriteLine("Ноль на ноль будет ноль");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Неизвестный код операции!");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}