using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1, enb = 0, enk = 9999, enb_konum=10, enk_konum=0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Bir Sayi Giriniz = ");
                sayi1 = Convert.ToInt16(Console.ReadLine());
                if (sayi1 > enb)
                {
                    enb = sayi1;
                    enb_konum = i;
                }
                if (sayi1 < enk)
                {
                    enk = sayi1;
                    enk_konum = i;
                }
            }
            Console.Write("En Büyük Sayi {0} dır ve {1} Konumda Girilmiştir. ", enb, enb_konum);
            Console.Write("En Küçük Sayi {0} dır ve {1} Konumda Girilmiştir. ", enk, enk_konum);
            Console.ReadKey();
        }
    }
}