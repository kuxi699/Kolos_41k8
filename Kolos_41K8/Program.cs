using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_41K8
{
     public class Program
    {

        public static void Rozwiazanie(int P,int Q,int R,int []A)
        {
           
            int Roz;
            Roz = A[P]*A[Q]*A[R];
           
            Console.Write(Roz);
           

        }


        static void Main(string[] args)
        {

            int[] A = { -3, 1, 2, -2, 5, 6 };
            Console.WriteLine(string.Join(",", A));
            Rozwiazanie(2, 4, 5,A);
            Console.ReadLine();

        }
    }
}
