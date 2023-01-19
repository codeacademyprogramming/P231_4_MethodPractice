using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 45;
            string name = "Hikmet";
            var result = num + 10;

            string surname=null;
            byte? age = null;

            Console.WriteLine(FindIndex(null,'l'));


            Console.WriteLine(num);
            Console.WriteLine(name);
        }


        static int FindIndex(string str,char cr)
        {
            if(str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == cr)
                        return i;
                }
            }
           

            return -1;
        }
    }
}
