using System;

/*
Name: OGENE SALOME .C.
MATRIC NUMBER: EES/18/19/0359
DEPARTMENT: ELECTRICAL/ELECTRONICS ENGINEERING
EEG 323 ASSIGNMENT
 */

namespace EEG_SEC_REWRITE
{
    class Program
    {
        static void Main(string[] args)
        {
            // while (true){

                float a,b,c,d,e,f;

                Console.WriteLine("Enter A:");
                a = Convert.ToSingle( Console.ReadLine() );

                Console.WriteLine("Enter B:");
                b = Convert.ToSingle( Console.ReadKey() );

                Console.WriteLine("Enter C:");
                c = Convert.ToSingle( Console.ReadLine() );

                Console.WriteLine("Enter D:");
                d = Convert.ToSingle( Console.ReadLine() );

                Console.WriteLine("Enter E:");
                e = Convert.ToSingle( Console.ReadLine() );

                Console.WriteLine("Enter F:");
                f = Convert.ToSingle( Console.ReadLine() );

                float determinant = (a*d) - (b*c);
                float changelnX   = (e*d) - (b*f);
                float changelnY   = (a*f) - (e*c);

                if (determinant == 0)
                {
                    Console.WriteLine("The equation has no solution.");
                    //continue;
                }
                else
                {
                    float x = changelnX/determinant;
                    float y = changelnY/determinant;

                    Console.WriteLine("the value of \n X is {0} \n Y is {1}", x, y);
                }
                // break;
                // }
        }
    }
}
        



        
