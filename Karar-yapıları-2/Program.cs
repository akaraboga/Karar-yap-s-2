using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Karar_yapıları_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("                 ------------------------------Kardeşler manava hoş geldiniz--------------------\n");

            Console.Write("Almak istediğiniz meyveyi seçiniz Muz/Çilek/Armut/Elma : ");
            string meyve = Console.ReadLine();

            /*
            meyve = meyve.ToLower(); // if ' in içine yazdığımız meyve ismi küçük harflerle olduğu için kullanıcı konsola büyük harfle yazdığında hata almasın diye ToLower() ekliyoruz.

            if (meyve == "muz") {          //koşulumuz string olduğu için çift tırnak içinde belirtiyoruz
             Console.WriteLine("Muzun kilosu = 4 tl");

         }
         else if(meyve == "çilek")
         {
             Console.WriteLine("Çileğin kilosu = 3 tl");
         }
         else if(meyve == "armut")
         {
             Console.WriteLine("armutun kilosu = 5 tl");
         }
         else
         {
             Console.WriteLine("diğer bütün meyveler 4 tl");
         }
             */

            meyve = meyve.ToUpper(); // Burdada aynı şekil switch ' in içine yazdığımız durumlar büyük harfle olduğu için kullanıcı konsola küçük harfle de yazsa büyük yapacak ve hata almicak.

            switch (meyve){
                case "MUZ": Console.WriteLine("Muzun kilosu = 4 tl");
                    break;

                case "ÇİLEK": Console.WriteLine("Çileğin kilosu = 3 tl");
                    break;

                case "ARMUT": Console.WriteLine("armutun kilosu = 5 tl");
                    break;

                default: Console.WriteLine("Diğer meyveler 4 tl");
                    break ;
            }
          
            Console.ReadLine();




            //siwtch mi if-else yapısı mı daha iyiye gelirsek bence kullandığımız yere göre değişir ikisininde kendisine göre avantajı var.



        }
    }
}
