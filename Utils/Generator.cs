using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix_Project.Utils
{
    public class Generator
    {
        static private Random rand = new Random();

        static public double[,] GenerateIdentityMatrix(int size)
        {
            double[,] identityMatrix = new double[size, size];
            for (int row = 0; row < size; row++)
            {
                identityMatrix[row, row] = 1;
            }
            return identityMatrix;
        }

        static public double[,] GenerateRandomMatrix(int rows, int columns)
        {
            double[,] randomMatrix = new double[rows, columns];
            //var rand = new Random();
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    randomMatrix[row, column] = (double)rand.Next(1, 10);
                }
            }
            return randomMatrix;
        }

        static public double[] GenerateRandomMatrix(int size)
        {
            double[] resultVector = new double[size];
            for (int row = 0; row < size; row++)
            {
                resultVector[row] = (double)rand.Next(1, 30);
            }
            return resultVector;
        }

        static public double[,] CreateAugmentedMatrix(int size, double[,] identityMatrix, double[,] randomMatrix)
        {
            double[,] augmentedMatrix = new double[size, 2 * size];

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < 2 * size; column++)
                {
                    if (column < size)
                    {
                        augmentedMatrix[row, column] = randomMatrix[row, column];
                    }
                    else
                    {
                        augmentedMatrix[row, column] = identityMatrix[row, column - size];
                    }
                }
            }

            return augmentedMatrix;
        }
    }
}