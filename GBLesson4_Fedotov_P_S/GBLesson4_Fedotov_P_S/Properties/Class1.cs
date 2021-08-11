using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBLesson4_Fedotov_P_S.Properties
{
    class Class1
    {
        static int[] num_mass = new int[20];
        static int quantity = 0;
        static Random random = new Random();

        static void set_num()
        {
            for (int i = 0; i < num_mass.Length;i++)
            {
                num_mass[i] = random.Next(-10000, 10000);
                Console.Write(num_mass[i] + ", ");
                if(i%5==0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void search()
        {
            for(int i=0;i<num_mass.Length-1;i++)
            {
                if(num_mass[i]%3==0 && num_mass[i + 1] % 3 == 0) { }
                else 
                {
                    if (num_mass[i] % 3 != 0 && num_mass[i + 1] % 3 != 0) { }
                    else
                    { 
                        quantity++;
                        Console.WriteLine(num_mass[i] + ", " + num_mass[i + 1]);
                    }
                }
            }
            Console.WriteLine("Количиство пар равно: " + quantity);
        }
        public static void RunLesson()
        {
            set_num();
            search();
            Console.WriteLine("Для продолжения нажмите ввод");
            Console.ReadLine();
        }
    }
}
