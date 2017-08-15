using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_31_41_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* program-31
            Console.WriteLine("Enter the day number");
            int day = Convert.ToInt16(Console.ReadLine());
            switch(day)
            {
                case 1:
                    {
                        Console.WriteLine("Sunday");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Monday");
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Tuesday");
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Wednesday");
                        Console.ReadLine();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Thursday");
                        Console.ReadLine();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Friday");
                        Console.ReadLine();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Saturday");
                        Console.ReadLine();
                        break;
                    }
                default:
                    Console.WriteLine("Invalid Input");
                    break;
             }*/

            /* program-32
            Console.WriteLine("Enter the digit");
              int digit = Convert.ToInt16(Console.ReadLine());
              switch (digit)
              {
                  case 0:
                      {
                          Console.WriteLine("Zero");
                          Console.ReadLine();
                          break;
                      }
                  case 1:
                      {
                          Console.WriteLine("One");
                          Console.ReadLine();
                          break;
                      }
                  case 2:
                      {
                          Console.WriteLine("Two");
                          Console.ReadLine();
                          break;
                      }
                  case 3:
                      {
                          Console.WriteLine("Three");
                          Console.ReadLine();
                          break;
                      }
                  case 4:
                      {
                          Console.WriteLine("Four");
                          Console.ReadLine();
                          break;
                      }
                  case 5:
                      {
                          Console.WriteLine("Five");
                          Console.ReadLine();
                          break;
                      }
                  case 6:
                      {
                          Console.WriteLine("Six");
                          Console.ReadLine();
                          break;
                      }
                  case 7:
                      {
                          Console.WriteLine("Seven");
                          Console.ReadLine();
                          break;
                      }
                  case 8:
                      {
                          Console.WriteLine("Eight");
                          Console.ReadLine();
                          break;
                      }
                  case 9:
                      {
                          Console.WriteLine("Nine");
                          Console.ReadLine();
                          break;
                      }
                  default:
                      Console.WriteLine("Invalid Input");
                      break;

              }*/

            /* program-33 
            Console.WriteLine("Enter the Month Number");
            int month = Convert.ToInt16(Console.ReadLine());
            switch (month)
            {
                
                case 1:
                    {
                        Console.WriteLine("January");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("February");
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("March");
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("April");
                        Console.ReadLine();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("May");
                        Console.ReadLine();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("June");
                        Console.ReadLine();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("July");
                        Console.ReadLine();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("August");
                        Console.ReadLine();
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("September");
                        Console.ReadLine();
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("October");
                        Console.ReadLine();
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("November");
                        Console.ReadLine();
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("December");
                        Console.ReadLine();
                        break;
                    }
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }*/

            /* program-34
            Console.WriteLine("Enter the Month Number");
             int month = Convert.ToInt16(Console.ReadLine());
             switch (month)
             {

                 case 1:
                     {
                         Console.WriteLine("31 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 2:
                     {
                         Console.WriteLine("28 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 3:
                     {
                         Console.WriteLine("31 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 4:
                     {
                         Console.WriteLine("30 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 5:
                     {
                         Console.WriteLine("31 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 6:
                     {
                         Console.WriteLine("30 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 7:
                     {
                         Console.WriteLine("31 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 8:
                     {
                         Console.WriteLine("31 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 9:
                     {
                         Console.WriteLine("30 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 10:
                     {
                         Console.WriteLine("31 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 11:
                     {
                         Console.WriteLine("30 Days");
                         Console.ReadLine();
                         break;
                     }
                 case 12:
                     {
                         Console.WriteLine("31 Days");
                         Console.ReadLine();
                         break;
                     }
                 default:
                     Console.WriteLine("Invalid Input");
                     break;

             }
             */
            /* Program-35
           Console.WriteLine("Choose the shape");
           Console.WriteLine(" 1.Circle\n 2.Square\n 3.Rectangle \n 4.Triangle\n 5.Parallelogram");
           int choice = Convert.ToInt16(Console.ReadLine());
           switch(choice)
           {
               case 1:
                   {
                       Console.WriteLine("Enter the radius");
                       int r = Convert.ToInt16(Console.ReadLine());
                       Console.WriteLine("{0}", (3.14 * r * r));
                       Console.ReadLine();
                       break;
                   }
               case 2:
                   {
                       Console.WriteLine("Enter the area");
                       int a = Convert.ToInt16(Console.ReadLine());
                       Console.WriteLine("{0}", (a * a));
                       Console.ReadLine();
                       break;
                   }
               case 3:
                   {
                       Console.WriteLine("Enter width and height");
                       int w = Convert.ToInt16(Console.ReadLine());
                       int h = Convert.ToInt16(Console.ReadLine());
                       Console.WriteLine("{0}", (w * h));
                       Console.ReadLine();
                       break;
                   }
               case 4:
                   {
                       Console.WriteLine("Enter base and height");
                       int b = Convert.ToInt16(Console.ReadLine());
                       int h = Convert.ToInt16(Console.ReadLine());
                       Console.WriteLine("{0}",( 0.5* b * h));
                       Console.ReadLine();
                       break;
                   }
               case 5:
                   {
                       Console.WriteLine("Enter base and height");
                       int b = Convert.ToInt16(Console.ReadLine());
                       int h = Convert.ToInt16(Console.ReadLine());
                       Console.WriteLine("{0}", (b * h));
                       Console.ReadLine();
                       break;
                   }
               default:
                   break;

           }*/

            /* program-36
            Console.WriteLine("Enter the two numbers");
             int a = Convert.ToInt16(Console.ReadLine());
             int b = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Enter your choice\n 1.Addition\n 2.Subtraction \n 3.Multiplication \n 4.Division");
             int choice = Convert.ToInt16(Console.ReadLine());
             switch (choice)
             {

                 case 1:
                     {
                         Console.WriteLine(a+b);
                         Console.ReadLine();
                         break;
                     }
                 case 2:
                     {
                         Console.WriteLine(a-b);
                         Console.ReadLine();
                         break;
                     }
                 case 3:
                     {
                         Console.WriteLine(a*b);
                         Console.ReadLine();
                         break;
                     }
                 case 4:
                     {
                         Console.WriteLine(a/b);
                         Console.ReadLine();
                         break;
                     }

                 default:
                     Console.WriteLine("Invalid Input");
                     break;
             }
             */

            /* program-37 int sum = 0;
             Console.WriteLine("Enter the n value");
             int n = Convert.ToInt16(Console.ReadLine());
             for(int i=1;i<= n;i++)
             {
                 sum = sum + i;
             }
             Console.WriteLine("Sum of {0} natural numbers are {1}", n, sum);
             Console.ReadLine();
             */

            /* program-38
            int sum = 0;
             Console.WriteLine("Enter the n value");
             int n = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("First {0} Natural numbers are", n);
             for (int i = 1; i <= n; i++)
             {
                 Console.WriteLine("{0}", i);
                 sum = sum + i;
             }
             Console.WriteLine("Sum of {0} natural numbers are {1}", n, sum);
             Console.ReadLine();*/

           /* program-39
           int sum = 0;
            Console.WriteLine("Enter the n value");
            int n = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int number = Convert.ToInt16(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("Sum of {0} numbers = {1} and average = {2}", n, sum,sum/n);
            Console.ReadLine();*/

            /* program-40
           Console.WriteLine("Enter the n value");
           int n = Convert.ToInt16(Console.ReadLine());
           Console.WriteLine("Cube of numbers are ");
           for (int i = 1; i <= n; i++)
           {
               Console.WriteLine("{0}", (i * i * i));
           }
           Console.ReadLine();
           */

            /* program-41 
            Console.WriteLine("Enter the n value");
             int n = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("{0} Natural numbers are ", n);
             for (int i = 1; i <= n; i++)
             {
                 Console.WriteLine("{0}", (2 * i - 1));
             } 
             Console.ReadLine();*/
        }
        }
    }

