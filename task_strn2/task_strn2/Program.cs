using System;

namespace TaskStrn
{


    class Program
    {
        static void Main(string[] args)
        {

            string word = "CodeAcademy is a good place to study.";

            int a = 0;
            int sozsayisi = 0;

            while (a <= word.Length-1)
            {
                if (word[a] ==' ' || word[a] =='.')
                {
                    sozsayisi++;
                }
                a++;


            }
            Console.WriteLine("Cumledeki Sozlerin Sayi:" + sozsayisi);













        }
    }



}