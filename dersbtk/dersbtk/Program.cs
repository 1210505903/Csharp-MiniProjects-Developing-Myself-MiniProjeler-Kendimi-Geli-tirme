 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersbtk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(multipy(2,3));
            Console.ReadLine();

        } 
        static int multipy(int nb1,int nb2)
        {
            return nb1 * nb2;
        }
        static int multipy2(int nb1, int nb2,int nb3)
        {
            return nb1 * nb2 * nb3;
        }
    }
}
