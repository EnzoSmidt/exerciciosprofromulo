using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.Atividade6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int numPar = 0;

            do
            {
                i = i + 2;
                numPar = i;
                Console.WriteLine(numPar);
            }
            while (i < 200);

            Console.ReadKey();
        }
    }
}
