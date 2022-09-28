using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix_Project.Logic
{
    public partial class CalculateSolution
    {


        static public double[] CalculateSolutionVectorUsingAugmentedMatrix(int size, double[] resultVector, double[,] inverseMatrix)
        {
            double[] solutionVector = new double[size];
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

            return solutionVector;
        }
    }
}