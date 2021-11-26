using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    /*
     * Разработать структуру для решения линейного уравнения 0=kx+b. 
     * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
     * Для решения уравнения предусмотреть метод Root. 
     * Создать экземпляр разработанной структуры. 
     * Осуществить использование экземпляра в программе.
     */
    class Program
    {
        static void Main(string[] args)
        {
            LineEquation x = new LineEquation { k = 8, b = -90 };//();
            //x.k = 5;
            //x.b = -9;

            Console.WriteLine("Решение уравнения 0={0} * x + ({1}), где x= {2}", x.k, x.b, x.Root());
            Console.ReadKey();
        }
    }
    public struct LineEquation
    {
        public double k;
        public double b;
        public double Root()
        {
            double res = 0;
            try
            { 
                res = (-1) * b / k;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                res = 0;
            }
            return res;
        }
    }
}
