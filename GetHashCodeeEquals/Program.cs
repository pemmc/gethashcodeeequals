using System;

namespace GetHashCodeeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b));

            a = "Maria";
            b = "Maria";

            Console.WriteLine(a.Equals(b));


            a = "Maria";
            b = "Alex";

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            a = "Maria";
            b = "Maria";

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            /* Resultado
            
                True
                -66323339
                475641941
                -66323339
                -66323339
            */


        }
    }
}
