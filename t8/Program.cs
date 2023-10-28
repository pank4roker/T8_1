using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t8
{
    internal class Program
    {
        //H.A

        //task1
        //Нахождение максимальной величины из двух целых переменных a, b
        /*public static int Max(int a, int b)
        {
            return a>b ? a : b;
        }*/
        //task2
        //Вычислить среднее арифметическое трех действительных чисел.
        /*public static int Mean(int a,int b,int c)
        {
            return (a + b + c) / 3;
        }*/
        //task3
        //Составьте таблицу значений функции y = 4x² + 5x - 10 на отрезке[-9; 9] с шагом h = 3.
        public static void Tab()
        {
            for(int x=-9;x<=9;x=x+3)
            {
                WriteLine($"x={x} \t y={4*Math.Pow(x,2)+5*x-10}");
            }
        }
        static void Main(string[] args)
        {
            //task1
            /* Write("Enter a: ");
             int a = Convert.ToInt32(ReadLine());
             Write("Enter b: ");
             int b = Convert.ToInt32(ReadLine());
             int max=Max(a, b);
             Write($"Maximum value: {max}");*/
            //task2
            /*Write("Enter a: ");
            int a = Convert.ToInt32(ReadLine());
            Write("Enter b: ");
            int b = Convert.ToInt32(ReadLine());
            Write("Enter c: ");
            int c = Convert.ToInt32(ReadLine());
            int d=Mean(a,b,c);
            Write($"arithmetic mean of three values: {d} ");*/
            //task3
            Tab();
            


            ReadKey();
        }
    }
}
