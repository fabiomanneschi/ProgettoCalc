using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCalc
{

        public class Calculator
        {
            public int Add(int x, int y)
            {
                return x + y;
            }

            public int Subtract(int x, int y)
            {
                return x - y;
            }

            public int Multiply(int x, int y)
            {
                return x * y;
            }

            public int? Divide(int x, int y)
            {
                try
                {
                    return (x / y);
                }
                catch
                {
                    Console.WriteLine("Attenzione non puoi dividere per zero!!!");
                    return null;
                }
            }
            public int? Potenza(int x, int y)
            {
            //try
            //{
                var ris = 0;
                ris = x ^ y;
                return (ris);
            //}
            //catch
            //{
            //    Console.WriteLine("Attenzione risultato out of range per var intere");
            //    return null;
            //}
        }


    }
    

}
