using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix_Project.Classes
{
    public class Logic
    {
        static public void FindInverseOfRandomMatrix(int size, double[,] augmentedMatrix, double[,] inverseMatrix)
        {
            for (int k = 0; k < size; k++)
            {
                double ratio = 1;

                for (int row = k + 1; row < size; row++)
                {
                    if (augmentedMatrix![k, k] != 0)
                    {
                        ratio = augmentedMatrix![row, k] / augmentedMatrix[k, k];
                    }
                    else
                    {
                        Console.WriteLine($"a[{k}] = {augmentedMatrix[k, k]}");
                        throw new Exception("Can not handle this issue, logic must be enhanced");
                    }

                    for (int column = 0; column < 2 * size; column++)
                    {
                        augmentedMatrix[row, column] = augmentedMatrix[row, column] - ratio * augmentedMatrix[k, column];
                    }
                }
            }

            for (int row = 0; row < size; row++)
            {
                double ratio = augmentedMatrix[row, row];

                for (int column = 0; column < 2 * size; column++)
                {
                    augmentedMatrix[row, column] = augmentedMatrix[row, column] / ratio;
                }
            }

            for (int k = size - 1; k >= 0; k--)
            {
                double ratio = 1;

                for (int row = k - 1; row >= 0; row--)
                {
                    if (augmentedMatrix![k, k] != 0)
                    {
                        ratio = augmentedMatrix![row, k] / augmentedMatrix[k, k];
                    }
                    else
                    {
                        Console.WriteLine($"a[{k}] = {augmentedMatrix[k, k]}");
                        throw new Exception("No solution");
                    }

                    for (int column = 0; column < 2 * size; column++)
                    {
                        augmentedMatrix[row, column] = augmentedMatrix[row, column] - ratio * augmentedMatrix[k, column];
                    }
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int column = size; column < 2 * size; column++)
                {
                    inverseMatrix[row, column - size] = augmentedMatrix[row, column];
                }
            }

        }

        static public void CalculateSolutionVector(int size, double[] resultVector, double[,] inverseMatrix, double[] solutionVector)
        {
            for (int row = 0; row < size; row++)
            {
                solutionVector[row] = 0;
                for (int column = 0; column < size; column++)
                {
                    solutionVector[row] += inverseMatrix[row, column] * resultVector[column];
                }

                if (solutionVector[row] == double.NaN)
                {
                    throw new Exception("There is no solution");
                }
            }
        }
    }
}