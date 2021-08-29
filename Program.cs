using System;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = default(int);
            float b = default(float);
            double c = default(double);
            decimal d = default(decimal);
            bool e = default(bool);
            char f = default(char);
            long g = default(long);
            string h = default(string);

            
            Console.WriteLine("Size of Integer data type :" + sizeof(int) + " and default value is :" + a );
            Console.WriteLine("Size of float type :" + sizeof(float) + " and default value is :" + b);
            Console.WriteLine("Size of Double data type :" + sizeof(double) + " and default value is :" + c);
            Console.WriteLine("Size of Decimal data type :" + sizeof(decimal) + " and default value is :" + d);
            Console.WriteLine("Size of Boolean data type :" + sizeof(bool) + " and default value is :" + e);
            Console.WriteLine("Size of Character data type :" + sizeof(char) + " and default value is :" + f);
            Console.WriteLine("Size of Long Integer data type :" + sizeof(long) + " and default value is :" + g);
            Console.WriteLine(" and default value is :" + h);
        }
    }
}
