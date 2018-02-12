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
         
2) Modify the program from Exercise 1 so that you do not have to create an instance of Math to call the four methods
*/
            DoAgain:
            Console.WriteLine("Enter first value");
            int v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second value");
            int v2 = Convert.ToInt32(Console.ReadLine());

            int result=0;
                       
            char select;

           
                Console.Write("Enter A for Addition, S for subtraction, M for multiplication, D for divide");
                select = Convert.ToChar(Console.ReadLine());
            
                switch (select)
                {
                    case 'a':
                    case 'A':
                        
                    result = MathClass.Addition(v1, v2);
                    break;

                    case 's':
                    case 'S':
                    result = MathClass.Subtract(v1, v2);
                        break;
                    case 'm':
                    case 'M':
                    result = MathClass.Multiply(v1, v2);
                        break;
                    case 'd':
                    case 'D':
                    result = MathClass.Division(v1, v2);
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
  
            Console.WriteLine(result);
            char choice;
            Console.Write("Y to doagain, N to exit");
            choice = Convert.ToChar(Console.ReadLine());
            
            if(choice=='y'||choice=='Y')
            {
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
