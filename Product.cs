using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Product
    {
        static void Main(string[] args)
        {
            //declare variables
            int n, prod = 1;

            //Prompt user to enter a number
            Console.Write("Enter a number: ");

            //Read in integer form user
            n = int.Parse(Console.ReadLine());

            //while-loop isolates the last digit using modulus,saving the value into 'prod'
            //next it changes the value of 'n' by shifting the decimal place (dividing by 10)
            //since the data type is an int it will not read after the decimal place essentially removing the last digit from 'n'
            //Ex. → n=12  | 12%10=2, prod=2 | 12/10=1.2, n=1|
            //               1%10=1, prod=2 | 1/10=0.1,  n=0| 

            while (n > 0)
            {
                prod *= (n % 10);
                n /= 10;
            }

            Console.Write("The Product is= " + prod);
            Console.ReadLine();
        }
    }
}
