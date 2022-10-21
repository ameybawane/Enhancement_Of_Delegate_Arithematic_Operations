using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancementOfDelegate_ArithematicOperations
{
    class Program
    {
        public delegate int MyDelegate(int x, int y);
        static void PerformArithmeticOperation(int num1, int num2, MyDelegate arOperation)
        {
            var result = arOperation(num1, num2);
            Console.WriteLine(result);
        }

        static void arthematicOperations()
        {
            Console.WriteLine("Please Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Add ");
            Console.WriteLine("2. Multiply ");
            Console.WriteLine("3. Subtract ");
            Console.WriteLine("4. Divide ");
            Console.WriteLine("5. Exit ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    MyDelegate arOperation1 = (int no1, int no2) => (no1 + no2);
                    PerformArithmeticOperation(num1, num2, arOperation1);
                    break;
                case 2:
                    MyDelegate arOperation2 = (int no1, int no2) => (no1 * no2);
                    PerformArithmeticOperation(num1, num2, arOperation2);
                    break;
                case 3:
                    MyDelegate arOperation3 = (int no1, int no2) => (no1 - no2);
                    PerformArithmeticOperation(num1, num2, arOperation3);
                    break;
                case 4:
                    MyDelegate arOperation4 = (int no1, int no2) => (no1 / no2);
                    PerformArithmeticOperation(num1, num2, arOperation4);
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            arthematicOperations();

            Console.ReadKey();
        }
    }
}
