using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_41K8
{
     public class Program
    {
        //Sortowanie Tablicy
        public static int[] Sortowanie(int[] tab)
        {            
            Array.Sort(tab);
            return tab;

        }


        public static int Rozwiazanie( int []tab)
        {
            tab = Sortowanie(tab);
                  
            int dlugoscTab = tab.Length;
            int wynik;
            Console.WriteLine(string.Join(",", tab));

            // goraMax Obliczanie maxymalnej liczby 3 górnych elementów tablicy
            // dolMax Obliczanie maxymalnej liczby 3 dolnych elementów tablicy
            int goraMax = tab[dlugoscTab - 1] * tab[dlugoscTab - 2] * tab[dlugoscTab - 3];
            int dolMax = tab[0] * tab[1] * tab[dlugoscTab - 1];

            // sprawdzanie który element jest większy;
            if (goraMax < dolMax)
            {               
                wynik = dolMax;   
                      
            }
            else
            {
                wynik = goraMax;
               
            }
            Console.WriteLine(wynik);
            return wynik;
           

        }


        static void Main(string[] args)
        {
           //tab tablica z której ma zostać znaleziony największy wynik mnożenie 3 elementów         
            int[] tab = { -3, 1, 2, -2, 5, 6 };           
            Rozwiazanie(tab);
            Console.ReadLine();

        }
    }
}
