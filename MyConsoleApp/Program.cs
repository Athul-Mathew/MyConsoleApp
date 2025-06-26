using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {   
                Console.WriteLine("hai this is the console app ");
            Console.WriteLine("WELCOME TO THE CALCULATOR APP");
                Console.WriteLine("press 5 for exit 1 for start ");
                double exit_num = Convert.ToDouble(Console.ReadLine());
                if (exit_num == 5)
                {
                    Console.WriteLine("thank ou");
                    break;
                }
                else if (exit_num == 1)
                {


                    Console.WriteLine("Enter the First Number for the calculation");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number for the calculation");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("which operation do you need press 1 for '+' press 2 for '-' press 3 for '*' press 4 for '/' press 5 for exit the code ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    double result;

                    switch (choice)
                    {

                        case 1:
                            result = num1 + num2;
                            Console.WriteLine("sum of two numbers is: " + result);
                            break;

                        case 2:
                            result = num1 - num2;
                            Console.WriteLine("the Answer of Substraction is :" + result);
                            break;

                        case 3:
                            result = num1 * num2;
                            Console.WriteLine("the answer is :" + result);
                            break;

                        case 4:
                            
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine("the answer is :" + result);
                                break;

                            }
                            else
                            {
                                Console.WriteLine("divission with zero wont work please enter any other number");
                                num2 = Convert.ToDouble(System.Console.ReadLine());
                                if (num2 != 0)
                                {
                                    result = num1 / num2;
                                    Console.WriteLine("excellent the Answer of "+num1+"divided by"+num2+"is:-"+result);
                                }
                                else
                                {
                                    Console.WriteLine("study basic maths and come back thank you ....");
                                    break;
                                }
                            }
                            break;

                        case 5:
                            Console.WriteLine("THANK YOU ");
                            return;

                        default:
                            Console.WriteLine("choosed wrong option");
                            break;

                    }
                }

            }

        }
    }
}
