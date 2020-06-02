using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma
{
    class Program
    {
        static void Main(string[] args)
        {
            int turma;
            int alunos;

            Console.Write("Quantidade de turmas existentes: ");
            turma = Convert.ToInt32(Console.ReadLine());
                       

            int[] qntdturmas = new int[turma];
                                    
            for (int i = 0; i < turma; i++)
            {
                Console.Write("Quantos alunos tem na turma " + (i+1) + ": ");
                alunos = Convert.ToInt32(Console.ReadLine());
                qntdturmas[i] = alunos;


                while (alunos > 40)
                {
                    Console.WriteLine("Por favor digite a quantidade de até 40 alunos");
                    Console.Write("Quantos alunos tem na turma " + (i + 1) + ": ");
                    alunos = Convert.ToInt32(Console.ReadLine());
                }
                               
            }

            Console.Clear();
            double media = qntdturmas.Average();
                        
            Console.WriteLine("A média de alunos é: " + media);


            Console.ReadLine();
        }
    }
}
