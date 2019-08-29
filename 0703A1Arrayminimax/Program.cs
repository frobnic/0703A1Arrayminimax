using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0703A1Arrayminimax
{
    class Program
    {
        static int[] ReadInArray(int NumOfElements)
        {
           
            int[] zahlen = new int[NumOfElements];

            for (int i=0; i < NumOfElements; i++)
            {
                Console.Write("Bitte Zahl {0,2} eingeben:",i+1);
                zahlen[i] = int.Parse(Console.ReadLine());
            }

            return zahlen;
        }

        static int FindMin(int[] SearchArray)
        {
            int a = int.MaxValue;
            foreach (int b in SearchArray)
            {
                if (b < a)
                    a = b;
            }
            return a;
        }

        static int FindMax(int[] SearchArray)
        {
            int a = int.MinValue;
            foreach (int b in SearchArray)
            {
                if (b > a)
                    a = b;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int[] zahlen;
            int anzahl;

            Console.Write("Wieviele Zahlen möchten Sie erfassen? (1-20)");
            anzahl = int.Parse(Console.ReadLine());

            zahlen = ReadInArray(anzahl);

            Console.WriteLine("Die kleinste Zahl ist {0}", FindMin(zahlen));
            Console.WriteLine("Die grösste  Zahl ist {0}", FindMax(zahlen));
        }
    }
}
