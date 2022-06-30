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
            Console.Write("Bir cümle gir : ");
            string sentence=Console.ReadLine();

            string[] word = sentence.Split(' ');

            Console.WriteLine("Kelime sayısı : " + word.Length);

            int letter = 0;
            foreach (var item in sentence)
            {
                if (item!=' ')
                {
                    letter++;
                }
            }
            Console.WriteLine("Harf sayısı : "+letter);
            Console.ReadLine();
        }
    }
}

//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
//Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
