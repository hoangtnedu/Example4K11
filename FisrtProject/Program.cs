//Thư viện/ Không gian tên/ Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FisrtProject;
namespace FisrtProject
{
    class Program
    {
        // hàm duy nhất trong 1 project
        static void Main(string[] args)
        {
           Console.Write("CHÀO LỚP IT03 K11 và IT04 K11\n") ;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("-------------------------\n");
            }
            // Nhập
            int a;
            Console.Write("Nhập a =");
            string b=Console.ReadLine();
            a = int.Parse(b);

            Console.Write("A ={0} {1}",a,a);
            Console.ReadKey();
        }
        
    }

}
