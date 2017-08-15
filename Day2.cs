using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program-6
            // Console.WriteLine("Enter the number");
            // int y = Convert.ToInt16(Console.ReadLine());
             for(int i=-5;i<=5;i++)
             {
                 Console.WriteLine(i * i - 2 * i + 1);
             }
             Console.ReadLine();*/


            /*  program-7
            Console.WriteLine("Enter the diatance and time");
             int d = Convert.ToInt16(Console.ReadLine());
             int t = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("speed={0}", d / t);
             Console.ReadLine();*/


            /*  program-8
            Console.WriteLine("Enter the radius");
              int r = Convert.ToInt16(Console.ReadLine());
              Console.WriteLine("volume={0}", (4 * 3.14 * r * r * r)/3);
              Console.WriteLine("Area={0}", 4 * 3.14 * r * r);
              Console.ReadLine();*/


            /* program-9
            Console.WriteLine("Enter the character");
             char c = Convert.ToChar(Console.ReadLine());
             if (c >= 48 && c <= 57)
                 Console.WriteLine("{0} is a digit", c);
             else if (c > 65 && c <= 90)
                 Console.WriteLine("{0} is a Capital letter", c);
             else if (c > 91 && c <= 122)
                 Console.WriteLine("{0} is a Small letter", c);
             else if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                 Console.WriteLine("{0} is a vowel", c);
             else
                 Console.WriteLine("{0} is a Symbols", c);
             Console.Read();*/


            /* program-10
            Console.WriteLine("Enter the 2 numbers");
             int a = Convert.ToInt16(Console.ReadLine());
             int b = Convert.ToInt16(Console.ReadLine());
             if (a % 2 == 0 && b % 2 == 0)
                 Console.WriteLine("true");
             else if(a % 2 != 0 && b % 2 != 0)
                 Console.WriteLine("false");
                 else
                 Console.WriteLine("Both even and odd");
             Console.Read();*/

            /*  program-12
            Console.WriteLine("Enter the number");
            int m = Convert.ToInt16(Console.ReadLine());
            int n = Convert.ToInt16(Console.ReadLine());
            if (m==n)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Not equal");
            Console.Read();*/


            /* program-13
            Console.WriteLine("Enter the number");
            int m = Convert.ToInt16(Console.ReadLine());
            if (m%2==0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            Console.Read();*/


            /* program-14
            Console.WriteLine("Enter the number");
            int m = Convert.ToInt16(Console.ReadLine());
            if (m < 0)
                Console.WriteLine("Negative");
            else 
                Console.WriteLine("Positive");
            Console.Read();*/

            /* program-15
            Console.WriteLine("Enter the year");
          int ye = Convert.ToInt16(Console.ReadLine());
          if (ye%4== 0)
              Console.WriteLine("Leap year");
          else
              Console.WriteLine("Not a leap year");
          Console.Read();*/

            /* program-16
            Console.WriteLine("Enter the age");
            int age = Convert.ToInt16(Console.ReadLine());
            if (age >=18)
                Console.WriteLine("Eligible to vote");
            else 
                Console.WriteLine("Not eligible");
            Console.Read();*/

            /* program-17
            Console.WriteLine("Enter the number");
            int m = Convert.ToInt16(Console.ReadLine());
            if (m<0)
                Console.WriteLine("-1");
            else if (m==0)
                Console.WriteLine("0");
            else if(m>0)
                Console.WriteLine("1");
            Console.Read();*/

            /* program-18
            Console.WriteLine("Enter the height");
            int h = Convert.ToInt16(Console.ReadLine());
            if (h<140)
                Console.WriteLine("Short");
            else if (h>141&&h<165)
                Console.WriteLine("medium");
            else
                Console.WriteLine("tall");
            Console.Read();*/

            /* program-19
            Console.WriteLine("Enter the number");
             int d = Convert.ToInt16(Console.ReadLine());
             int e = Convert.ToInt16(Console.ReadLine());
             int f = Convert.ToInt16(Console.ReadLine());
             if (d > e && d > f)
                 Console.WriteLine("{0} is greater", d);
             else if(e>f)
                 Console.WriteLine("{0} is greater", e);
             else
                 Console.WriteLine("{0} is greater", f);
             Console.Read();*/


            /* program-20
            Console.WriteLine("Enter the coordinate points x and y");
             int x = Convert.ToInt16(Console.ReadLine());
             int y = Convert.ToInt16(Console.ReadLine());
             if (x > 0 && y > 0)
                 Console.WriteLine(" First Quadrant");
             else if (x < 0 && y > 0)
                 Console.WriteLine(" Second Quadrant");
             else if (x < 0 && y < 0)
                 Console.WriteLine(" Third Quadrant");
             else if (x > 0 && y < 0)
                 Console.WriteLine(" Fourth Quadrant");
             else if (x == 0 && y == 0)
                 Console.WriteLine("Origin");
             Console.ReadLine();*/


            /* program-21
            Console.WriteLine("Enter the maths mark");
             int m = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Enter the phy mark");
             int p = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Enter the che mark");
             int c = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Enter the total mark");
             int t = Convert.ToInt16(Console.ReadLine());
             if (m >= 65 && p >= 55 && c >= 50 && t >= 180)
             {
                 Console.WriteLine("Eligible for the course");
             }
             else
                 Console.WriteLine("Not Eligible");
             Console.WriteLine();*/
            
            /* program-23
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the Rollno");
            string r = Console.ReadLine();
            Console.WriteLine("Enter the 3 subject marks");
            int m1 = Convert.ToInt16(Console.ReadLine());
            int m2 = Convert.ToInt16(Console.ReadLine());
            int m3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Total marks={0} \n Average={1}", (m1 + m2 + m3), (m1 + m2 + m3) / 3 * 100);
            Console.ReadLine();
            */

            /* program-24
            Console.WriteLine("Enter the temperature");
            int c = Convert.ToInt16(Console.ReadLine());
            if (c <0)
                Console.WriteLine("Freezing weather");
            else if (c > 0 && c <= 10)
                Console.WriteLine("Very cold weather");
            else if (c > 10&& c <=20)
                Console.WriteLine("Cold weather");
            else if (c > 20 && c <= 30)
                Console.WriteLine("Normal in Temp");
            else if (c > 30 && c <= 40)
                Console.WriteLine("Its hot");
            else
                Console.WriteLine(" Its Very hot");
            Console.Read();*/


            /*  program-27
            Console.WriteLine("Enter the alphabet");
             char c = Convert.ToChar(Console.ReadLine());
              if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                 Console.WriteLine("{0} is a vowel", c);
             else
                 Console.WriteLine("{0} is a Consonant", c);
             Console.Read();*/

            /* program-28
          Console.WriteLine("Enter the 2 Prices");
          int cp = Convert.ToInt16(Console.ReadLine());
          int sp = Convert.ToInt16(Console.ReadLine());
          if (cp>=sp)
              Console.WriteLine("Loss={0}",cp-sp);
          else
              Console.WriteLine("Profit={0}",sp-cp);
          Console.Read();*/







            /* program-30
            Console.WriteLine("Enter the Grade");
              char g = Convert.ToChar(Console.ReadLine());
              if (g =='E' )
                  Console.WriteLine("Excellent");
             else if (g == 'V')
                  Console.WriteLine("Very Good");
              if (g == 'G')
                  Console.WriteLine("Good");
              if (g == 'A')
                  Console.WriteLine("Average");
              if (g == 'F')
                  Console.WriteLine("Fail");
              else
                  Console.WriteLine("Invalid grade..try again...");
              Console.Read();*/


            /* program-42
            Console.WriteLine("Enter the size");
            size= Convert.ToInt16(Console.ReadLine());
            for(int i=1;i<=size;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();*/

            /* problem -43
            Console.WriteLine("Enter the size");
            size= Convert.ToInt16(Console.ReadLine());
           for (int i = 1; i <= size; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write("{0}",j);
                 }
                 Console.WriteLine();
             }
             Console.Read();*/

            /* problrm-44
            Console.WriteLine("Enter the size");
            size= Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}",i);
                }
                Console.WriteLine();
            }
            Console.Read();*/

            /*// program-45
            int count = 1;
            Console.WriteLine("Enter the size");
            size= Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}",count++);
                }
                Console.WriteLine();
            }
            Console.Read();*/
        }
    }
}
