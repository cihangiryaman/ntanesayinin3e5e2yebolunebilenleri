using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12cihangir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("girilecek sayı adedini giriniz");
            int N = Convert.ToInt32(Console.ReadLine());

            
            int bToplam = 0;
            int cToplam = 0;
            int kToplam = 0;
            int b = 0;
            int c = 0;
            int k = 0;

            for (int x = 1; x <= N; x = x +1)
            {
                Console.WriteLine(" sayıyı gir");
                int s = Convert.ToInt32(Console.ReadLine());

                if (s % 5 == 0)
                {
                    Console.WriteLine("5 e bölünebilir");

                    b = b + 1;
                    bToplam = bToplam + s;

                }
                if (s % 3 == 0)
                {
                    Console.WriteLine("3 e bölünebilir");

                    c = c + 1;
                    cToplam = cToplam + s;

                }
                if (s % 2 == 0)
                {
                    Console.WriteLine("2 e bölünebilir");

                    k = k + 1;
                    kToplam = kToplam + s;

                }
            }

            
            Console.WriteLine("5 e bölünenlerin sayısı " + b);
            Console.WriteLine("3 e bölünenlerin sayısı " + c);
            Console.WriteLine("2 e bölünenlerin sayısı " + k);
            Console.WriteLine("5 e bölünenlerin toplamı " + bToplam);
            Console.WriteLine("3 e bölünenlerin toplamı " + cToplam);
            Console.WriteLine("2 e bölünenlerin toplamı " + kToplam);

            Console.ReadLine();
        }
    }
}
