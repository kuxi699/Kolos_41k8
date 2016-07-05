using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_41K8
{
     public class Program
    {

        public static void Rozwiazanie( int []tab)
        {
                    
            Array.Sort(tab);          
            int dlugosc = tab.Length;
            int wynik;
            Console.WriteLine(string.Join(",", tab));

            int goraMax = tab[dlugosc - 1] * tab[dlugosc - 2] * tab[dlugosc - 3];
            int dolMax = tab[0] * tab[1] * tab[dlugosc - 1];


            if (goraMax < dolMax)
            {
               
                wynik = dolMax;
                Console.Write(wynik);
            }
            else
            {
                wynik = goraMax;
                Console.Write(wynik);

            }

                       
  
        }


        static void Main(string[] args)
        {
                    
            int[] tab = { -3, 1, 2, -2, 5, 6 };           
            Rozwiazanie(tab);
            Console.ReadLine();

        }
    }
}
