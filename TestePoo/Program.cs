using System;

namespace TestePoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Desafio4();
        }

        private static void Desafio4()
        {
            string[] vogais = { "a", "e", "i", "o", "u" };

            Console.WriteLine("Digite uma letra: ");
            string letra = Console.ReadLine().ToLower();
            bool ehVogal = false;

            foreach (var item in vogais)
            {
                if (letra == item)
                {
                    ehVogal = true;

                }
            }

            if (ehVogal)
            {
                Console.WriteLine($"A letra {letra} é uma vogal!");
            }
            else
            {
                Console.WriteLine($"A letra {letra} é uma consoante!");
            }

            Console.ReadLine();
        }
    }
    
}
