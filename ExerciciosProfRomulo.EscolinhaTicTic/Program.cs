using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3;
            double soma;
            double media;
            double somafinal;
            double mediafinal;
            string nome;
            

            //entrada dos dados
            Console.WriteLine("Qual seu nome Rovem Rovem");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota");             
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            nota3 = double.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3;         
            media = soma / 3;
            
            Console.WriteLine();
            Console.WriteLine(nome);

            Console.WriteLine();
            somafinal = Math.Round(soma, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"A soma é:{somafinal}");                     

            Console.WriteLine();

            if (media >= 7)
            {

                mediafinal = Math.Round(media, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"O aluno {nome} obteve a média {mediafinal} e foi aprovado.");            
                Console.WriteLine();            
            }
            else
            {
                mediafinal = Math.Round(media, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"O aluno {nome} obteve a média {mediafinal} e foi reprovado.");
                Console.WriteLine();
            }
           
            Console.ReadKey();
        }
    }
}
