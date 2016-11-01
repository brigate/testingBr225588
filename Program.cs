using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algoritmi
{
    class Program
    {
        #region Faktorijel
        private static int Faktorijel(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Faktorijel(n - 1);
            }
        }
        #endregion
        

        #region Racunanje sa Nizom brojeva
        private static int ZbirPrvihN(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }
            return s;
        }
        #endregion

        #region IspisBrojeva
        private static void IspisBrojeva()
        {
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("i={0} j={1}", i, j);
                }
                Console.WriteLine();
            }
        }

        private static void IspisDvocifrenihBrojeva()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.Write("{0}{1} ", i, j);
                }
                Console.WriteLine();
            }
        }

        private static void IspisDvocifrenihBrojevaSaIstimCiframa()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0}{1} ", i, j);
                    }
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Ispis imena
        private static void IspisIme()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("IME ");
                }
                Console.WriteLine();
            }
        }

        private static void IspisImeICrtice1()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("IME ");
                }
                for (int j = 3; j >= i; j--)
                {
                    Console.Write("--- ");
                }


                Console.WriteLine();
            }
        }

        private static void IspisImeICrtice2()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3 - i; j++)
                {
                    Console.Write("--- ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("IME ");
                }



                Console.WriteLine();
            }
        }
        #endregion

        #region Ispis dijagonale
        private static void IspisPoGlavnojDijagonali()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == j)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void IspisIspodGlavneDijagonale()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("+");
                }

                for (int j = 1; j <= 4 - i + 1; j++)
                {
                    Console.Write("-");
                }

                Console.WriteLine();
            }
        }

        private static void IspisIznadGlavneDijagonale()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-");
                }
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write("+");
                }



                Console.WriteLine();
            }
        }

        private static void IspisPoSporednojDijagonali()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 6 - i)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Ispis Trougao
        private static void Trougao1()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }

        private static void Trougao2()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("3 ");
                    }
                    else
                    {
                        Console.Write("x ");
                    }

                }
                Console.WriteLine();
            }
        }

        private static void Trougao3()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }
        }

        private static void Trougao4()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(2 * j + " ");

                }
                Console.WriteLine();
            }
        }

        private static void Trougao5()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.Write(Math.Pow(2, j - 1) + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Trougao6()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < i + i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Trougao7()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int k = ZbirPrvihN(i);
                for (int j = k; j > k - i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Trougao8()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 5 * i; j < 2 * 5 * i; j += 5)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Trougao9()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }

        private static void Trougao10()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("I ");
                    }
                    else
                    {
                        Console.Write("x ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Trougao11()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    k += 1;
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Trougao12()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j < i + i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Trougao13()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }

        private static void Trougao14()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine();
            }

        }

        private static void Trougao15()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (2 * n - 1) - (2 * i - 1); j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("I ");
                    }
                    else
                    {
                        Console.Write("x ");
                    }
                }
                Console.WriteLine();
            }

        }

        private static void Trougao16()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (n + i - 1); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (n - i + 1); j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

        }

        private static void Trougao17()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine();
            }

        }

        private static void Trougao18()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 2 * i - 2; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= (2 * n - 1) - (2 * i - 2); j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("I ");
                    }
                    else
                    {
                        Console.Write("x ");
                    }
                }
                Console.WriteLine();
            }

        }

        private static void Trougao19()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                Console.WriteLine();
            }

        }

        private static void Trougao20()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                Console.WriteLine();
            }

        }

        private static void Trougao21()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine();
            }

        }

        private static void Trougao22()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine();
            }

        }

        private static void Trougao23()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(".");
                }
                Console.Write("x");
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

        }

        private static void Trougao24()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(".");
                }
                Console.Write("x");
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

        }

        private static void Trougao25()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                if (i == 1)
                {
                    Console.WriteLine();
                }
                for (int j = 1; j <= 2 * (i - 1) - 1; j++)
                {
                    Console.Write(" ");
                }
                if (i > 1)
                {
                    Console.Write("x");
                    Console.WriteLine();
                }
            }
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                Console.Write("x");
            }

        }

        private static void Trougao26()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                if (i == n - 1)
                {
                    Console.WriteLine();
                }
                for (int j = 1; j <= 2 * (n - 1 - i) - 1; j++)
                {
                    Console.Write(" ");
                }
                if (i < n - 1)
                {
                    Console.Write("x");
                    Console.WriteLine();
                }
            }


        }
        #endregion

        #region Dijamant
        private static void Dijamant1()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * n - 1 - 2 * i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void Dijamant2()
        {
            char[] niz = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(niz[i - 1]);
                if (i == 1)
                {
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= 2 * (i - 1) - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(niz[i - 1]);
                    Console.WriteLine();
                }
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(niz[i - 1]);
                if (i == 1)
                {
                    Console.WriteLine();
                }
                for (int j = 1; j <= 2 * (i - 1) - 1; j++)
                {
                    Console.Write(" ");
                }
                if (i > 1)
                {
                    Console.Write(niz[i - 1]);
                    Console.WriteLine();
                }
            }
        }

        private static void Dijamant3()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                for (int j = 2; j <= n - i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine(Faktorijel(2));
            Console.ReadLine();
        }
    }
}
