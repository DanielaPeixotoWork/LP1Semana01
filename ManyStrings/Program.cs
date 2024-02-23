using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            String N1 = "Helloooo!!";
            String N2 = "This is a star \u2606 !";
            String N3 = "ol\\á e\\ a\\deu\\s";

            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);

            int x =10;
            int y = 5;

            String M1 = "a" + 2;
            String M2 = "abc" + x;

            String interp1 = $"valor de x e {x}";
            String interp2 = $"{x} mais {y} e igual a {x + y}";

            Console.WriteLine(M1);
            Console.WriteLine(M2);
            Console.WriteLine(interp1);
            Console.WriteLine(interp2);
        }
    }
}
