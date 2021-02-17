using System;

namespace aula_3
{
    class Program
    {
        static void Main(string[] args)
        {

            using(System.IO.TextWriter w = System.IO.File.CreateText("texto.txt"))
            {
                for (int i = 0; i <= 1000; i++)
                {
                    string num1 = Convert.ToString(i);
                    w.WriteLine("Linha" + num1);
                }
                w.Dispose();
            }

        }
    }
}
