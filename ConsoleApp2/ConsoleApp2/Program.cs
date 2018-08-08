using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int soma = 0;
            for (int i = 0; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
