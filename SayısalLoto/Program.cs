using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayısalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int[] sayilar = new int[6];



            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + ".Kolon : ");

                for (int j = 0; j < 6; j++)
                {

                    int sayi = rastgele.Next(1, 50);
                    int yoksa = Array.IndexOf(sayilar, sayi);
                    if (yoksa == -1)
                    {
                        sayilar[j] = sayi;
                        if (j < 5)
                        {
                            Console.Write("{0} - ", sayilar[j]);
                        }
                        else
                        {
                            Console.Write("{0} ", sayilar[j]);
                        }

                    }
                    else
                    {
                        j--;
                    }

                }
                Console.WriteLine();


            }

            Console.Read();
        }
    }
}
