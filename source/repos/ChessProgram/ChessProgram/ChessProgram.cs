using System;
namespace ChessDashboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, remainder;
            for (i = 1; i <= 8; i++)
            {
                if (i % 2 == 0)
                {
                    remainder = 1; 
                }
                else
                {
                    remainder = 0; 
                }
                for (j = 1; j <= 8; j++)
                {
                    if (j % 2 == remainder)
                    {
                        Console.Write("WW");
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("BB");
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}