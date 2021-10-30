using System;

namespace CalculatorApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            calculatorMethods obj = new calculatorMethods();
            Console.WriteLine("Want to use calculator...y/n");
            char ch1 = Convert.ToChar(Console.ReadLine());
            char consent = ch1;
            
            while(consent=='y'||consent=='Y')
            {
                Console.WriteLine("Enter options from 1-4: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch(key)
                { 
                    case 1:
                    Console.WriteLine("enter 2 numbers:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int sum = obj.getsum(num1, num2);
                    Console.WriteLine("Sum is" + sum);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("enter 2 numbers:");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    int dif = obj.getdif(num3, num4);
                    Console.WriteLine("Difference is" + dif);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("enter 2 numbers:");
                    int num5 = Convert.ToInt32(Console.ReadLine());
                    int num6 = Convert.ToInt32(Console.ReadLine());
                    int mul = obj.getmul(num5, num6);
                    Console.WriteLine("Multiplication is" + mul);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("enter 2 numbers:");
                    int num7 = Convert.ToInt32(Console.ReadLine());
                    int num8 = Convert.ToInt32(Console.ReadLine());
                    int div = obj.getsum(num7, num8);
                    Console.WriteLine("Division is" + div);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Please Enter Input between 1-4");
                    break;
                }
                Console.WriteLine("Continue...y/n");
                char ch = Convert.ToChar(Console.ReadLine());
                consent = ch;
            }
        }
    }
}
