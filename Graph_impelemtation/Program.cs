using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_impelemtation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix Row ");
            int row= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter matrix Col ");
            int col = int.Parse(Console.ReadLine());


            int[,] matrex = FillMatrex(row,col);
 
            PrintMatrix(matrex);
            Console.WriteLine();

            ShowNig(0, matrex);
            Console.WriteLine();



        }

        public static void ShowNig(int v, int[,] matrex)
        {
            int sum = 0;

            for (int row = 0; row < matrex.GetLength(0); row++)
            {
                for (int col = v; col < v+1; col++)
                {
                    if (matrex[row,v]==1)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine("Vertix {0} have {1} neighbours",v,sum);
        }

            public static  void PrintMatrix(int [,] matrex)
        {


            for (int i = 0; i < matrex.GetLength(0); i++)
            {
                for (int j = 0; j < matrex.GetLength(1); j++)
                {
                    Console.Write(matrex[i, j] + " ");
                }
                Console.WriteLine();

            }
        }

        private static int[,] FillMatrex(int row , int col)
        {
            int[,] matrex = new int[row, col];

            for (int i = 0; i < matrex.GetLength(0); i++)
            {
                for (int j = 0; j < matrex.GetLength(1); j++)
                {
                    if (i == j) // element is dignal
                    {
                        matrex[i, j] = 0;
                    }
                    else // element is not dignal
                    {
                        matrex[i, j] = 1;

                    }
                }
            }

            return matrex;
        }
    }
}
