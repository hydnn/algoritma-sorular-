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
            int a, n;
            Console.Write("Bir sayı gir : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] seri = new int[n];

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} . sayıyı gir : ", i);
                a= Convert.ToInt32(Console.ReadLine());
                seri[i - 1] = a;
            }
            
            Console.Write("Girdiğiniz sayılar arasındaki çift sayılar :");
            foreach (var item in seri)
            {
                if (item%2==0)
                {
                    Console.Write("\t"+item+"\t");
                }               
            }

            Console.ReadLine();
        }
    }
}

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
