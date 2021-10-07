using System;

namespace HotelPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciamento da classe
            Hospede[] vect = new Hospede[10];
            //Input para gerar a matriz
            Console.WriteLine("Quantos quartos serao alugados ?");
            int n = int.Parse(Console.ReadLine());
            
            //Loop da Matriz
            //Input e Processamento de dados
            for (int i =1; i<=n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Hospede # {i}");
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Email");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto :");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Hospede(nome, email);
            }
            //Output de dados
            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i<10; i++)
            {
               if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
