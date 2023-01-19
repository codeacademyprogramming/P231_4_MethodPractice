using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Abbas", "Nermin", "Tofiq", "Hikmet" };

            Console.WriteLine(HasValue(names,"Totu"));

            int[] numbers = { 45, 23, 45, 456, 67, 787, 3, 422, 454, 57, 87 };

            Console.WriteLine(HasValue(numbers,45));

            Console.WriteLine(HasValue(numbers, new int[] { 100, 67, 300 }));


            string word = "Hello World!";

            var result = Substring(word,4);

            Console.WriteLine(word);
            Console.WriteLine(result);

            //Layihe ise dusdukdue console-dan email deyeri daxil etmeyimizi istesin
            //Eger email @ simvolu yoxdursa yeniden daxil etmeyimizi istesin

            string email;

            do
            {
                Console.WriteLine("Email daxil edin:");
                email = Console.ReadLine();


            } while (FindIndex(email,'@') == -1);
           
        }

        //Verilmis adlar siyahisinda verilmis adin olub olmadigini tapan metod

        static bool HasValue(string[] arr,string value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return true;
            }

            return false;
        }


        //Verilmis ededler siyahisinda verilmis ededin oldub olmaddigini tapan metod
        static bool HasValue(int[] arr,int value)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return true;
            }

            return false;
        }


        //Verilmis ededler siyahisinda verilis diger ededler siyahisindan hansisa
        //ededin olub olmadigini tapan metod

        static bool HasValue(int[] arr,int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                //for (int j = 0; j < arr.Length; j++)
                //{
                //    if (arr[j] == values[i])
                //        return true;
                //}

                if (HasValue(arr, values[i]))
                {
                    return true;
                }
            }
            return false;
        }


        //Verilmis charin reqem olub olmadigini tapan bir metod
        static bool IsDigit(char cr)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == cr)
                    return true;
            }

            return false;
        }

        //Verilmis yazida reqem olub olmadigini tapan bir metod
        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (IsDigit(str[i]))
                    return true;
            }

            return false;
        }

        //Verilmis yazinin icerisinde verilmis charin indexini tapan metod

        static int FindIndex(string str,char cr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                    return i;
            }

            return -1;
        }

        //Verimis yazini verilmis indexe qeder kesib qaytaran metod

        static string Substring(string str,int index)
        {
            string newStr = "";

            for (int i = 0;i < index; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }


        

    }
}
