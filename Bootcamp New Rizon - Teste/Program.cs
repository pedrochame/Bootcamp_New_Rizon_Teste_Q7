using System;

namespace Bootcamp_New_Rizon___Teste
{
    internal class Program
    {

        static int nTriangular(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + nTriangular(n - 1);

        }

        static string desenhaTriangulo(int n)
        {
            if (n == 1)
            {
                return "O";
            }

            string r = "";
            for(int i=0; i < n; i++)
            {
                r += "O";
            }

            return r + '\n' + desenhaTriangulo(n - 1);

        }

        static void Main(string[] args)
        {

            int x;
            Console.Write("N: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("\nN-ésimo número triangular: ");
            Console.WriteLine(nTriangular(x));
            Console.WriteLine("\nTriângulo: ");
            Console.WriteLine(desenhaTriangulo(x));
            Console.ReadLine();

        }
    }
}