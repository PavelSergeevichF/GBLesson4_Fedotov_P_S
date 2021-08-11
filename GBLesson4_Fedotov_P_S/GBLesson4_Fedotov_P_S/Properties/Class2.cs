using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBLesson4_Fedotov_P_S.Properties
{
    class Class2
    {
        int[] num_mass;
        
        public Class2(int size_mass, int start=0, int step=1)
        {
            int temp = start;
            num_mass = new int[size_mass];
            Console.WriteLine("Исходный массив:");
            for (int i=0;i<num_mass.Length;i++)
            {
                num_mass[i] = temp;
                Console.Write(num_mass[i] + ", ");
                if (i % 10 == 0) Console.WriteLine();
                temp += step;
            }
        }
        public long Sum()
        {
            long temp=0;
            foreach(int i in num_mass)
            {
                temp += i;
            }
            return temp;
        }
        public int[] inverse()
        {
            int[] invers_num_mass=num_mass;
            for(int i=0;i<invers_num_mass.Length;i++)
            {
                invers_num_mass[i] = -1 * num_mass[i];
            }
            return invers_num_mass;
        }
        public void Multi( int multi, out int MaxCount)
        {
            MaxCount = 0;
            int temp = -2000000;
            for(int i=0;i<num_mass.Length;i++)
            {
                num_mass[i] *= multi;
                if (num_mass[i] > temp) temp = num_mass[i];
            }
            for (int i = 0; i < num_mass.Length; i++)
            {
                if (num_mass[i] == temp) MaxCount++;
            }
        }
    }
}
