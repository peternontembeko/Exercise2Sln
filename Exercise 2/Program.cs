using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1, str2 = "";
            int i;
            Console.WriteLine("Please enter a string");
            str1 = Console.ReadLine();

            for (i = 0; i < str1.Length; i++)

            {
                if(str1[i] =='a' || str1[1] == 'e' || str1[1] == i || str1[1] == 'o'|| str1[1] =='u' || str1[1] =='A' || str1[1] =='E'|| str1[1]=='O'|| str1[1] =='U')
                {

                }
                else
                {
                    str2 = str2 + str1[i];
                }
                Console.WriteLine(str2);
            }
            Console.WriteLine(str2);
            Console.ReadLine();
        }
}   }
