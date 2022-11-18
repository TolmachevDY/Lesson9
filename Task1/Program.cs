using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число. X = ");
            try
            {
                double X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целое число. Y = "); ;
                double Y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n" +
                    "     1 - сложение\n" +
                    "     2 - вычитание\n" +
                    "     3 - произведение\n" +
                    "     4 - частное");
                Console.Write("Ваш выбор: ");
                string n = Console.ReadLine();
                switch (n)
                {
                    case "1":
                        Console.WriteLine("Результат = {0}", X + Y);
                        break;
                    case "2":
                        Console.WriteLine("Результат = {0}", X - Y);
                        break;
                    case "3":
                        Console.WriteLine("Результат = {0}", X * Y);
                        break;
                    case "4":
                        Console.WriteLine("Результат = {0}", X / Y);
                        break;
                    default:
                        Console.WriteLine("Нет операции с указанным номером");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
