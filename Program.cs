using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int NumeroChamada = 0;
            String Nome_Aluno = "Gabriel Ferreira Sasdelli ";

            NumeroChamada = 1;
            Console.WriteLine(NumeroChamada);
            Console.WriteLine(Nome_Aluno);

            Console.WriteLine(args[0].ToString());
            Console.WriteLine(args[1].ToString());
            Console.WriteLine(args[2].ToString());
            Console.WriteLine(args[3].ToString());

            Console.WriteLine("Hello World!");
        }
    }
}
