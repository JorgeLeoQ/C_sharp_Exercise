using System;

namespace Exercise10
{
    public class Matrix
    {
        static void Main(string[] args)
        {
            int sizeMatrix;
            int[,] returnMatrix; //catch the value returned by the methods

            Console.Write("Enter size of square matrices: ");
            while ((int.TryParse(Console.ReadLine(), out sizeMatrix)) == false || (sizeMatrix <= 1))
            {
                Console.Write("Error. Enter a valid value: ");
            }//only matrix from 2x2 to nxn (with n >= 2)

            Console.WriteLine("\nMatrix in mode \"A\"");
            returnMatrix = AMatrix(sizeMatrix);
            PrintMatrix(returnMatrix);

            Console.WriteLine("\nMatrix in mode \"B\"");
            returnMatrix = BMatrix(sizeMatrix);
            PrintMatrix(returnMatrix);

            Console.WriteLine("\nMatrix in mode \"C\"");
            returnMatrix = CMatrix(sizeMatrix);
            PrintMatrix(returnMatrix);

            Console.WriteLine("\nMatrix in mode \"D\"");
            returnMatrix = DMatrix(sizeMatrix);
            PrintMatrix(returnMatrix);
        }

        //that method print the matrix on the console 
        static public void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write("{0} ", matrix[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        //Method that initialize a matrix in the first mode
        static public int[,] AMatrix(int sizeM)
        {
            int[,] matrix = new int[sizeM, sizeM];

            int index = 1;
            for (int column = 0; column < matrix.GetLength(0); column++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[row, column] = index++;
                }
            }

            return matrix;
        }

        //Method that initialize a matrix in the second mode
        static public int[,] BMatrix(int sizeM)
        {
            int[,] matrix = new int[sizeM, sizeM];

            int index = 1;
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (column % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, column] = index++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, column] = index++;
                    }
                }
            }

            return matrix;
        }

        //Method that initialize a matrix in the third mode
        static public int[,] CMatrix(int sizeM)
        {
            int[,] matrix = new int[sizeM, sizeM];

            int column;
            int row;

            int index = 1;
            for (row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (column = 0; row + column < matrix.GetLength(1); column++)
                {
                    matrix[row + column, column] = index++;
                }
            }

            for (column = 1; column < matrix.GetLength(1); column++)
            {
                for (row = 0; row + column < matrix.GetLength(1); row++)
                {
                    matrix[row, row + column] = index++;
                }
            }

            return matrix;
        }

        //Method that initialize a matrix in the fourth mode
        static public int[,] DMatrix(int sizeM)
        {
            int i, j, k; //control variables
            int[,] matrix = new int[sizeM, sizeM];
            int index = 1;

            for (i = 0; i <= sizeM / 2 - 1; i++)
            {
                for (k = i; k < sizeM - 1 - i; k++)
                {
                    matrix[k, i] = index++;
                }

                for (j = i; j < sizeM - 1 - i; j++)
                {
                    matrix[k, j] = index++;
                }

                for (k = sizeM - 1 - i; k > i; k--)
                {
                    matrix[k, j] = index++;
                }

                for (j = sizeM - 1 - i; j > i; j--)
                {
                    matrix[k, j] = index++;
                }
            }

            if (sizeM % 2 != 0)
            {
                matrix[sizeM / 2, sizeM / 2] = index;
            }

            return matrix;
        }
    }
}
