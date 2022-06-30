using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("n değerini gir : "); ; n=Convert.ToInt32(Console.ReadLine());
            Console.Write("m değerini gir : "); ; m=Convert.ToInt32(Console.ReadLine());

            int[] seri = new int[n];

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} . sayıyı gir : ",i);
                int a = Convert.ToInt32(Console.ReadLine()); 
                seri[i-1] = a;
            }

            foreach (var item in seri)
            {
                if (item == m || m % item == 0) 
                {
                    Console.WriteLine("\n"+item);
                }
            }
            Console.ReadLine();
        }
    }
}

//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
//
