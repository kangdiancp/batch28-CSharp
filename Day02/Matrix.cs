using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Matrix
    {
        
        //4 matrix diagonal
        public static int[,] MatrixDiagonal(int row,int col)
        {
            int[,] matrix = new int[row,col];
            int counter = 0;

            //fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;

                    }else if(j > i)
                    {
                        matrix[i,j] = 10;
                    }
                }
            }
            return matrix;
        }

        
        //3 display matrix
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        
        //2
        public static int[,] FillRandomMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];  
            
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(21);
                }
            }
            
            return matrix;
        }
        
        
        //1
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];

            matrix[0, 0] = 15;
            matrix[1, 1] = 15;
            matrix[2, 4] = 45;

            char[,] matrixChar=
            {
                {'A','B','C' }, // baris 0
                {'D','E','F' }, // baris 1
                {'G','H','I' } // baris 2
            };
        }


    }
}
