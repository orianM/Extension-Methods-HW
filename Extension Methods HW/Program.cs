using System;

namespace Extension_Methods_HW
{
    static class Program
    {
        #region question 1

        static bool HasLowerChars(this string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == char.ToLower(s[i]))
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region question 2

        static string ReverseCase(this string s)
        {
            string Reversed = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == char.ToLower(s[i]))
                {
                    Reversed += char.ToUpper(s[i]);
                }
                else
                {
                    Reversed = s[i].ToString();
                    Reversed = Reversed.ToLower();
                }
            }
            return Reversed;
        }

        #endregion

        #region question 3

        static void Print(this int x)
        {
            if (x > 100)
                Console.WriteLine("Enough!");
            else
                Console.WriteLine("Seventy Four");
        }

        #endregion

        #region question 4

        static int MultipleBy(this int x, int multiplier)
        {
            return x * multiplier;
        }

        #endregion

        #region question 5

        static bool IsNull(this object obj)
        {
            if (obj == null)
                return true;
            else
                return false;
        }

        #endregion

        static void Main(string[] args)
        {
            string hello1 = "Hello";
            string hello2 = "HELLO";

            #region question 1

            Console.WriteLine(hello1.HasLowerChars());
            Console.WriteLine(hello2.HasLowerChars());

            #endregion

            #region question 2

            Console.WriteLine(hello1.ReverseCase());

            #endregion

            #region question 3

            int num = 102;
            num.Print();
            num = 74;
            num.Print();

            #endregion

            #region question 4

            Console.WriteLine(num.MultipleBy(3));

            #endregion

            #region question 5

            object myObj = null;
            if (myObj.IsNull())
                Console.WriteLine("Null");
            else
                Console.WriteLine("Not Null");

            #endregion

        }
    }
}
