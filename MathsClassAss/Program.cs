using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsClassAss
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         
1) Declare a Maths class that has 4 non-static methods for Add, Sub, Mul, and Divide. each of which takes 2 parameters. call
each method from the Main() and output  the their result to console window.
*/
            DoAgain:
            Console.WriteLine("WELCOME TO MATHEMATICS BASIC OPERATION CLASS\n");
            Console.WriteLine("Enter first value");
            int v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second value");
            int v2 = Convert.ToInt32(Console.ReadLine());

            int result=0;
            MathClass MC = new MathClass(); 
                       
            char select;

           
                Console.Write("Enter A for Addition, S for subtraction, M for multiplication, D for divide");
                select = Convert.ToChar(Console.ReadLine());
            
                switch (select)
                {
                    case 'a':
                    case 'A':
                    
                    result = MC.Addition(v1, v2);// result= MC.Addition(v1,v2);
                    Console.WriteLine("{0}+{1}={2}", v1, v2, result);
                    break;

                    case 's':
                    case 'S':
                    result = MC.Subtract(v1, v2);
                    Console.WriteLine("{0}-{1}={2}", v1, v2, result);
                    break;
                    case 'm':
                    case 'M':
                    result = MC.Multiply(v1, v2);
                    Console.WriteLine("{0}*{1}={2}", v1, v2, result);
                    break;
                    case 'd':
                    case 'D':
                    result = MC.Division(v1, v2);
                    Console.WriteLine("{0}/{1}={2}", v1, v2, result);
                    break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
  
            Console.WriteLine(result);
            char choice;
            Console.Write("Y to doagain, N to exit");
            choice = Convert.ToChar(Console.ReadLine());
            
            if(choice=='y'||choice=='Y')
            {
                Console.Clear();
                goto DoAgain;
            }
            else if (choice=='N' || choice=='n')
            {
                goto Finish;
            }
            else
            {
                Console.WriteLine("wrong input");
            }

            Finish: Console.WriteLine("anykey to exit");
            Console.ReadKey();
            
            Console.ReadLine();

        }
        
    }
}
