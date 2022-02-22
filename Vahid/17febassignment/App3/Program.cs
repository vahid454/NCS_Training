// See https://aka.ms/new-console-template for more information
//C# program to calculate the total of employee's salary 
//using the Aggregate() method. 

using System;
using System.Linq;
using System.Collections.Generic;

public class QuestionThree
{
   
    static void Main(string[] args)
    {
        Display1();
        Console.WriteLine("-------------------------------");
        Display2();
        Console.WriteLine("-------------------------------");
        Display3();
        Console.WriteLine("-------------------------------");
        Display4();
        Console.WriteLine("-------------------------------");
        Display5();
        Console.WriteLine("-------------------------------");
        Display6();
    }

    public static void Display1()
    {
        /*        abcdef
                  abcde 
                  abcd
                  abc
                  ab
                  a
        */
        int i = 0;
        for (i = 6; i >= 1; i--)
        {
            for (int j = 1; j <=i; j++)
            {
                Console.Write((char)(j + 64));
            }
            Console.WriteLine();
        }

    }
    public static void Display2()
        {
        /*
        A
        BC
        DEF
        GHIJ
        KLMNO
        */
        int i, j;
        char c='A';
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j <= i; j++)
            {
                Console.Write(c);
                c++;
            }
            Console.WriteLine();
        }


        }
    public static void Display3()
    {
        /*
        2
        4  6
        8 10 12
        14 16 18 20
        */
        int i, j;
        int s = 2;
        for (i = 1; i <= 4; i++)
        {
            for (j = 1; j <=i; j++)
            {
               
            Console.Write(s+ "\t");
                s = s + 2;

            }
           
            Console.WriteLine();
        }

    }
    public static void Display4()
    {

        /*
        A
        BCD
        EFGH
        ILKLMN
        */
        int i, j;
        char c = 'A';
        for (i = 1; i < 5; i++)
        {
         
            for (j = 1; j<=(i*2-1); j++)
            {
                if (j == 5) continue;
                Console.Write(c);
                c++;
            }
            Console.WriteLine();
        }


    }
    public static void Display5()
    {
        /*        
                *****
                ****
                ***
                **
                *
        */
        int i, j;
         for (i = 5; i >= 1; i--)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
                
            }
            Console.WriteLine();
        }

    }

    public static void Display6()
    {
        /*
            A
          B  C
         D  E F
        G H  I J
        */
        int i, j;
        int n = 5;
        int m = n;
        char c= 'A';
        for (i = 1; i <=n; i++)
        {
            for (j = 1; j < m +1; j++) Console.Write(" ");
            for(int k=1;k<=i-1;k++)
            {
                Console.Write(c+" ");
                c++;
            }
            m--;
            Console.WriteLine();
        }

    }

}
