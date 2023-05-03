using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_30_04_2023
{
    internal class FactorialProgram
    {
        static void Main(string[] args)

        {

            // 1. Write a factorial program using recursion.
            Console.Write("Enter a number : ");
            int i = Convert.ToInt32(Console.ReadLine());

            int fact = GetFactorial(i);

            Console.WriteLine(i + "factorial is" + fact);


            // 2. Write a C# program and compute the sum of the digits of an integer.
            int num, sum = 0, temp;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                temp = num % 10;
                sum = sum + temp;
                num = num / 10;
            }
            Console.Write("Sum of each digit is : " + sum);


            // 3. Write a C# program to check a given integer and return true if it is within 10 of 100 or 200.


            // 4. Write a C# program to exchange the first and last characters in a given string and return the new string.
            string str, newstr;
            char firstchar, lastchar;
            Console.Write("Enter a String: ");
            str = Console.ReadLine();

            int len = str.Length;
            firstchar = str[0];
            lastchar = str[len - 1];
            newstr = lastchar + str.Substring(1, len - 2) + firstchar;
            Console.WriteLine("New string after swapping first and last charters is : " + newstr);


            // 5. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
            Console.Write("Enter a number: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            if (numb % 3 == 0 || numb % 7 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Flase");
            }


            // 6. Write a C# program to check if a given string starts with 'C#' or not.
            string strcheck, strtemp;
            Console.Write("Enter a String: ");
            strcheck = Console.ReadLine().ToUpper();

            if (strcheck.Length > 1)
            {
                strtemp = strcheck.Substring(0, 2);
                if (strtemp == "C#")
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("flase");
                }
            }
            else
            {
                Console.WriteLine("flase");
            }


            // 7. Write a C# program to check if two given non-negative integers have the same last digit.
            int n1, n2, last1, last2;
            Console.Write("Enter a first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 % 10 == n2 % 10)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


            // 8. Write a program in C# to display the pattern like right angle triangle using an asterisk.
            Console.Write("How many lines you want in the pattern : ");
            int nline = Convert.ToInt32(Console.ReadLine());
            int a, b;

            for (a = 1; a <= nline; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }

            // 9. Write a program in C# to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
            int sterms, totalsum = 0, tsum = 1;
            string strterms = "";

            Console.Write("Input the number of terms : ");
            sterms = Convert.ToInt32(Console.ReadLine());

            for (int k = 1; k <= sterms; k++)
            {
                totalsum = totalsum + tsum;

                strterms = strterms + tsum.ToString() + " + ";

                tsum = (tsum * 10) + 1;
            }
            Console.WriteLine(strterms);
            Console.WriteLine("The Sum is : " + totalsum);


            // 10. Write a program in C# to display the first n terms of Fibonacci series.
            int termnum, lastnum = 0, currentnum = 1, nextnum;
            Console.Write("Input number of terms to display : ");
            termnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here is the Fibonacci series upto to " + termnum + " terms :");
            Console.Write(lastnum);

            for (int j = 1; j < termnum; j++)
            {
                Console.Write(" " + currentnum);
                nextnum = lastnum + currentnum;
                lastnum = currentnum;
                currentnum = nextnum;
            }


            // 11. Write a program in C# to count a total number of alphabets, digits and special characters in a string.
            Console.Write("Enter a string :");
            string fullstr = Console.ReadLine();

            int totalSpecialChar = 0, totalLetter = 0, totalDigit = 0;

            foreach (var ch in fullstr)
            {
                int chascii = (int)ch;

                if ((chascii >= 32 && chascii <= 47) || (chascii >= 58 && chascii <= 64) || (chascii >= 91 && chascii <= 96) || (chascii >= 123 && chascii <= 126))
                {
                    totalSpecialChar++;
                }
                if ((chascii >= 65 && chascii <= 90) || (chascii >= 97 && chascii <= 122))
                {
                    totalLetter++;
                }
                if (chascii >= 48 && chascii <= 57)
                {
                    totalDigit++;
                } 
            }

            Console.WriteLine("Total number of Special Character in string : " + totalSpecialChar);
            Console.WriteLine("Total number of Alphabets in string : " + totalLetter);
            Console.WriteLine("Total number of Digits in string : " + totalDigit);


            Console.ReadKey();
        }

        public static int GetFactorial(int n)

        {
            if (n == 0)

            {
                return 1;
            }
            return n * GetFactorial(n - 1);

        }
    }
}
