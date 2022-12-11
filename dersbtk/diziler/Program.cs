using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {// tek boyutlu diizileri biliyorum
         string[,] bolgeler = new string[5, 3] {
                {"İst","edirne","kırklareli"}, 
                {"Ankara","Konya","Kırkkale"},
                {"Antalya","Adana","Mersin" }, 
                {"Rize","Trabzon","Samsun" }, 
                {"İzmir","Muğla","Manisa" }

            };// burda amacımız tr deki 5 bölgeye 3 büyük şehir ekliycez
            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);
                }
                Console.WriteLine("-------------");//ayırmak için bölgeleri
            }
            Console.ReadLine();
          }
    }
}
