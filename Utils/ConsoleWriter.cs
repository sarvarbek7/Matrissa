using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix_Project.Utils
{
    public class ConsoleWriter
    {
        static public void WriteArrayToConsole(int rows, int columns, double[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                    //Console.Write("{0:0.0} ", matrix[row, column]);
                }
                Console.WriteLine();
            }
        }
        static public void WriteArrayToConsole(int size, double[] matrix)
        {
            Console.Write("< ");
            for (int i = 0; i < size; i++)
            {
                if (i != size - 1)
                    Console.Write($"{matrix[i]}, ");
                else
                    Console.Write($"{matrix[i]} ");
                //Console.Write("{0:0.0} ", matrix[row, column]);
            }
            Console.WriteLine(">");
        }
    }
}