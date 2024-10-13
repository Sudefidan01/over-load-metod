using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230813_OverLoadMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programımız içerisinde bazı durumlarda aynı fonksiyon adında farklı işleyişler yaptırma imkanı sağlayabiliriz
            //Örnek olarak içerisine 2 adet int sayıyı parametre olarak tutan bir metodumuz olsun.Bu fonksiyonu çalıştırabilmemiz için fonksiyon çağırma işlemi esnasında 2 adet int sayıyı göndermemiz gerekiyor.Ben aynı fonskiyon adı altın int sayı değilde double sayıları toplamak istediğim durumlarda overload metod yöntemine başvurabilirim
            OverLoadMetodlar metodlar=new OverLoadMetodlar();
            Console.Write("1.Fonskiyon = ");
            metodlar.Topla(5,10);

            Console.Write("2.Fonskiyon = ");
            metodlar.Topla(5.1,8.3);

            Console.Write("3.Fonskiyon = ");
            metodlar.Topla(3,8,9);

            Console.Write("4.Fonksiyon = ");
            metodlar.Topla(2.7,8.4,10.4);


            Console.ReadKey();
        }
    }
}
