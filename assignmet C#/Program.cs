using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int a = 5;
            int b;
            b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            b = 3;
            Console.WriteLine(a);
            Console.WriteLine(b);
            /*
             * it will print
             * 5
             * 5
             * 5
             * 3
             * */
            #endregion
            #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            point p1;
            p1 = new point();
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            point p2 = new point();
            p1 = p2;
            p2.x = 4;
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);
            /*
             * it will print
             * 0
             * 0
             * 4
             * 0
             * 4
             * 0
             * */

            #endregion
            print(4);


        }
        #region Write a program that allows the user to enter a number then print it.
        static void print(int a)
        {

            Console.WriteLine(a);
        }
        #endregion


        class point
        {
            public int x;
            public int y;

        }


    }




}
