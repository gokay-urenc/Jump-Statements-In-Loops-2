using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_Jump_Deyimleri_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___________________BREAK___________________");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; // Continue olsaydı 5 atlanarak devamı yazılırdı. Ama break direk döngüyü sonlandırdı.
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("_________________CONTINUE__________________");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue; // Break olsaydı döngü 5 ve sonrası dahil yazılmazdı. Ama continue sadece 5'i atladı.
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("__________________RETURN___________________");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    // return; // Altında ne kod olduğunu umursamadan direk Main'in sonuna gider.
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
