using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int[] v1= new int[1000]; //vectori de frecventa
        static int[] v2 = new int[1000];
        static int n1;
        static int n2;
        static void Main(string[] args)
        {
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            int[] A = new int[n1];
            int[] B = new int[n2];
            int[] Rez = new int[n1 + n2];
            int k = 0;
            for (int i = 0; i < n1; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                v1[A[i]]++;
            }
            for (int i = 0; i < n2; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
                v2[B[i]]++;
             }

            //reuniunea A si B

            for (int i = 0; i < 1000; i++)
                if (v1[i] != 0 || v2[i] != 0)
                {
                    Rez[k] = i;
                    k++;
                }
            for (int i = 0; i < k; i++)
                Console.Write(Rez[i]+ " ");
            Console.WriteLine();

            //intersectia A si B
            k = 0;
            for (int i = 0; i < 1000; i++)
                if (v1[i] != 0 && v2[i] != 0)
                {
                    Rez[k] = i;
                    k++;
                }
            for (int i = 0; i < k; i++)
                Console.Write(Rez[i] + " ");
            Console.WriteLine();

            // diferenta A\B
            k = 0;
            for (int i = 0; i < 1000; i++)
                if (v1[i] != 0 && v2[i] == 0)
                {
                    Rez[k] = i;
                    k++;
                }
            for (int i = 0; i < k; i++)
                Console.Write(Rez[i] + " ");
            Console.WriteLine();
            

            //diferenta B\A
            k = 0;
            for (int i = 0; i < 1000; i++)
                if (v1[i] == 0 && v2[i] != 0)
                {
                    Rez[k] = i;
                    k++;
                }

            for (int i = 0; i < k; i++)
                Console.Write(Rez[i] + " ");

            Console.ReadKey();

        }
    }
}
