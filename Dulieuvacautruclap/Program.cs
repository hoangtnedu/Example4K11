using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulieuvacautruclap
{
    class Program
    {
        static void Main(string[] args)
        {
            int iSonguyenA;
            Console.Write("Nhap so a: =");
            string i = Console.ReadLine();
            iSonguyenA = int.Parse(i);
            int t = 0;
            int so = 2;
            Console.Write("T =");
            while (so<=iSonguyenA)
            {
                if (so==2)
                {
                    Console.Write(" {0}", so);
                }
                else
                Console.Write("+ {0}", so);
                t += so;
                so += 2;                
            }

            Console.Write("\nTong la: {0}",t);
            Console.ReadLine();

        }
    }
}
