using System.Data.Common;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{
    public delegate int PerformCalculation(int x, int y);
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }
        static int Up(int a, int b)
        {
            return a * b;
        }
        static int Down(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            PerformCalculation obj = null;
            Console.WriteLine("First numder");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second numder");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("operator\n1 - +\n2 - -\n3 - *\n4 - /");
            int oper = Convert.ToInt32(Console.ReadLine());

            switch (oper) 
            {
                case 1:
                    obj = Add;
                    break;
                case 2:
                    obj = Minus;
                    break;
                case 3:
                    obj = Up;
                    break;
                case 4:
                    obj = Down;
                    break;
                default: 
                    Console.WriteLine("error");
                    break;
            }
            int ans = obj(num1, num2);
            Console.WriteLine(ans);
        }
        
    }
}