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
            int n; string m;
            Console.Write("n değerini gir : "); ; n=Convert.ToInt32(Console.ReadLine());

            string[] seri = new string[n];

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} . kelimeyi gir : ",i);
                m = Console.ReadLine(); 
                seri[i-1] = m;
            }

            Array.Reverse(seri);
            foreach (var item in seri)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
//Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
//
