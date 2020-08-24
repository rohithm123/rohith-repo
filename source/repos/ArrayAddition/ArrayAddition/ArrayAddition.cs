using System;
using System.Data;
using System.Text.Json.Serialization;

namespace ArrayAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of coloumns:");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row,col];
            int[,] b = new int[row,col];
            int[,] c = new int[row,col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    

                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                   
                    b[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    c[i,j] = a[i,j] + b[i,j];
                    Console.WriteLine(c[i,j]);

                }
            }
        }
    }
}
