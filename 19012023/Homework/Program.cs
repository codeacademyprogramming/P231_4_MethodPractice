using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 34, 2, 56, 34, 76 };

            Console.WriteLine(FindMin(numbers));

            Console.WriteLine(FindCharCount("Salamlar",'a'));

            Console.WriteLine(FindIndex(numbers,55));


            Console.WriteLine(Reverse("Hello, World!"));
            

        }

        static int FindMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        static int FindCharCount(string str,char cr)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                {
                    count++;
                }
            }

            return count;
        }

        static int FindIndex(int[] arr,int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    return i;
            }

            return -1;
        }

        static string Reverse(string str)
        {
            string newStr = "";
            for (int i = str.Length-1; i >=0; i--)
            {
                newStr += str[i];
            }

            return newStr;
        }

    }
}
