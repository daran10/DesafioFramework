using System;

namespace DesafioFramework
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i, j, k, l, n;
            Console.Write("digite um número para formar a pirâmide:   ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <=n; i++)
            {
                    for (j = n - i; j>0; j--)
                   {
                       Console.Write("    ");
                   }

                {
                    for (k = 1; k < i; k++)
                    {
                        Console.Write("framework", k);
                    }
                    for(l = i; l > 0; l--)
                    {
                        Console.Write(" ", l);
                    }
                
                    Console.WriteLine();
                }
                    
            }
        }
    }
}
