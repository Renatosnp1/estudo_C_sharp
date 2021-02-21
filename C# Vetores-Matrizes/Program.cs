using System;

namespace C__Vetores_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Qual e seu Nome?");
            // string nome = Console.ReadLine();
            string nome = "Renato Vinicius Carneiro De Mattos";


            string[] nome_split = nome.Split(' ');


            for (int i = 0; i < nome.Length ; i++)
            {
                Console.WriteLine(nome[i]);
            }
            
            foreach(String n in nome_split){
                Console.WriteLine(n);
            }

            Console.ReadLine();


        }
    }
}
