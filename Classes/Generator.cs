using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix_Project.Classes
{
    public class Generator
    {
        static private Random rand = new Random();
        static public void GenerateIdentityMatrix(int size, double[,] identityMatrix)
        {
            for (int row = 0; row < size; row++)
            {
                identityMatrix[row, row] = 1;
            }
        }

        static public void GenerateRandomMatrix(int size, double[,] randomMatrix)
        {
            //var rand = new Random();
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    randomMatrix[row, column] = (double)rand.Next(1, 10);
                }
            }
        }

        static public void CreateAugmentedMatrix(int size, double[,] identityMatrix, double[,] randomMatrix, double[,] augmentedMatrix)
        {
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
        }

        static public void GenerateResultVector(int size, double[] resultVector)
        {
            for (int row = 0; row < size; row++)
            {
                resultVector[row] = (double)rand.Next(1, 30);
            }
        }
    }
}