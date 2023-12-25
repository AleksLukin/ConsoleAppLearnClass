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
            new KvUr();
            
            Console.ReadLine();
        }
    }
    class KvUr
    {
        private double Discriminant;
        private double a;
        private double b;
        private double c;


        internal KvUr()
        {
            Input();

            Discriminant = Math.Pow(b, 2) - (4 * a * c);

            Output();
        }
        internal void Input()
        {
            Console.WriteLine("Введите значения a,b и c больше нуля: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
        }
        internal void Output()
        {
            //this.Discriminant = Discriminant;
            //this.a = a;
            //this.b = b;
            //this.c = c;     
            
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
        



