using System;
using System.Text;

namespace TaskString
{

    class Program
    {
        static string ReverseText(string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
           
            string word = "java";
            Console.WriteLine("Input:" + word);
            string reserved= ReverseText(word);
            Console.WriteLine("Output:"+ reserved.ToUpper());










        }
    }




}