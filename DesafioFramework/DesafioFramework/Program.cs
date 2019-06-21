using System;

public class Program
{
    public static void Main()
    {
        /*Este é um programa para implementar uma piramide com a palavra "framework" */
        {
           
            Console.WriteLine("Piramide com a palavra framework: Tecle enter ");
            Console.ReadLine();
            int linhas = 15;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < linhas - i; j++)
                { 
                    Console.Write("    ");
                }
              

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("framework");
                }
                

                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
   
    }

} 