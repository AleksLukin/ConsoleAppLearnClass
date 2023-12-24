using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearnClass
{
    class Address
    {
        /// <summary>
        /// Задание 9. Создание класса для арифметических вычислений
        /// Рассмотрим Программу решения квадратного уравнения с использование класса KvUr
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения a,b и c больше нуля: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

             new KvUr(a, b, c);
            

            Console.ReadLine();
        }
    }
    class KvUr
    {
        private double a;
        private double b;
        private double c;

        public KvUr(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            double Discriminant = Math.Pow(b, 2) - (4 * a * c);

            if (Discriminant > 0)
            {
                double xOne = (-b + Math.Sqrt(Discriminant)) / 2 / a;
                double xTwo = (-b - Math.Sqrt(Discriminant)) / 2 / a;
                Console.WriteLine($"Первое неизвестное число равно {0}, второе {1}", xOne, xTwo);
            }
            if (Discriminant == 0)
            {
                double x = (-b) / 2 / a;

                Console.WriteLine($"Неизвестное число равно {0}", x);
            }
            if (Discriminant < 0)
            {
                Console.WriteLine($"Дискриминант {Discriminant} меньше нуля, следовательно уравнение не имеет действительных корней");
            }
        }
    }
}
        



