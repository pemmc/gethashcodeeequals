using System;

using GetHashCodeeEquals.Entities;

namespace GetHashCodeeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Como o GetHashCode é mais rápido
            //Então quando eu achar um elemento que tem o mesmo HASHCODE...
            //Daí sim a gente usa o EQUALS...

            Clients a = new Clients { Name = "Maria", Email = "maria@gmail.com"};
            Clients b = new Clients { Name = "Alex", Email = "alex@gmail.com"};

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            /*  RESULTADO
                    False
                    298195988
                    465141759
             */

            Clients c = new Clients { Name = "Maria", Email = "maria@gmail.com" };
            Clients d = new Clients { Name = "Maria Lord", Email = "maria@gmail.com" };

            Console.WriteLine(c.Equals(d));
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());

            /*  RESULTADO
                    True
                    298195988
                    298195988
             */

            //o IGUAL IGUAL ele tá comparando a referência do ponteiro de memória do objeto
            Console.WriteLine(a == b);

            //são iguais do ponto de vista do conteúdo, mas difentes do ponto de vista da referência
            Console.WriteLine(c.Equals(d));
            Console.WriteLine(c == d);

            /*  RESULTADO
                    False
                    True
                    False
            */

        }
    }
}
