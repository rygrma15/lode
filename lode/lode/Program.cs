using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lode
{
    enum Akce
    {
        Prazdno = 1, Lod, Zasah, Minul
    }

    class Program
    {
        static void Main(string[] args)
        {
            char[] pismenaPole = "0ABCDEFGHIJ".ToCharArray();
            int[,] morePole = new int[11, 11];
            int i = 0;
            int x = 0;



            for (i = 1; i <= 10; i++)
            {
                for (x = 1; x <= 10; x++)
                {
                    morePole[i, x] = (int)Akce.Prazdno;
                }
            }




            morePole[5, 5] = (int)Akce.Lod;
            morePole[6, 5] = (int)Akce.Lod;
            morePole[7, 5] = (int)Akce.Lod;
            morePole[8, 5] = (int)Akce.Lod;


            /*
            for (i = 0; i <= 9; i++)
            {
                for (x = 0; x <= 9; x++)
                {
                    Console.Write(morePole[i, x]);
                }
                Console.WriteLine("");
            }

            */
            while (true)
            {

                Console.Write("Zadej první souřadnici: ");
                string vstup1 = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Zadej druhou souřadnici: ");
                string vstup2 = Console.ReadLine();
                int souradnice1 = 0;
                int souradnice2 = 0;
                souradnice1 = int.Parse(vstup1);
                souradnice2 = int.Parse(vstup2);
                if (morePole[souradnice1, souradnice2] == (int)Akce.Prazdno)
                {
                    morePole[souradnice1, souradnice2] = (int)Akce.Minul;
                }
                else if (morePole[souradnice1, souradnice2] == (int)Akce.Lod)
                {
                    morePole[souradnice1, souradnice2] = (int)Akce.Zasah;
                }
                else if (morePole[souradnice1, souradnice2] == (int)Akce.Zasah || morePole[souradnice1, souradnice2] == (int)Akce.Minul)
                {
                    Console.WriteLine("---!!!Již aktivováno!!!---");

                }

                for (i = 0; i <= 10; i++)
                {
                    if (i != 0)
                    {
                        Console.Write(i + ": ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    for (x = 1; x <= 10; x++)
                    {
                        if (i == 0)
                        {
                            Console.Write(pismenaPole[x]);
                        }

                        else if (morePole[i, x] == (int)Akce.Lod)
                        {
                            Console.Write((int)Akce.Prazdno);
                        }
                        else
                        {
                            Console.Write(morePole[i, x]);
                        }

                    }
                    Console.WriteLine("");

                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
