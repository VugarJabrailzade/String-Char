using System;


namespace TaskStrng
{



    class Program
    {
        static void Main(string[] args)
        {


            string word = "Hello World";
            int sait = 0;
            int samit = 0;
            int len = word.Length;

            for (int i = 0; i <word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' ||
                word[i] == 'i' || word[i] == 'o' ||
                word[i] == 'u' || word[i] == 'A' ||
                word[i] == 'E' || word[i] == 'I' ||
                word[i] == 'O' || word[i] == 'U')
                {
                    sait++;
                }

                else if (word[i] <= 'z' && word[i] >= 'a' || word[i] >= 'A' && word[i] <= 'Z')
                {
                    samit++;
                }
            }

            Console.WriteLine("Saitlerin sayi:" + sait);
            Console.WriteLine("Samitlerin sayi:" + samit);












        }
    }



}