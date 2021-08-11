using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBLesson4_Fedotov_P_S
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties.Class1.RunLesson();

            Random random = new Random();
            Properties.Class2 cl2 = new Properties.Class2
                (
                random.Next(10,10000), 
                random.Next(-10000, 10000), 
                random.Next(0, 10)
                );
            Console.WriteLine("Сумма массива равна: " + cl2.Sum());
            Console.WriteLine();
            int[] mass=cl2.inverse();
            int temp = 0;
            Console.WriteLine("Инверсивный массив:");
            foreach (int i in mass)
            {
                Console.Write(i + ", ");
                temp++;
                if (temp % 10 == 0) Console.WriteLine();
            }
            Console.WriteLine();
            int tmp = 0;
            cl2.Multi(random.Next(2, 5),out tmp);
            Console.WriteLine("Максимальных чисел равно:"+ tmp);
            Console.WriteLine("Для выхода нажмите Enter");
            Console.ReadLine();
        }
    }
}
