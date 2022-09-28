using System;
using Matrix_Project.Utils;
using Matrix_Project.Logic;
// See https://aka.ms/new-console-template for more information

var watch = new System.Diagnostics.Stopwatch();

int size = 2;
double[,] randomMatrix = new double[size, size];
double[,] identityMatrix = new double[size, size];
double[,] augmentedMatrix = new double[size, 2 * size];
double[,] inverseMatrix = new double[size, size];
double[] resultVector = new double[size];
double[] solutionVector = new double[size];

watch.Start();

// Generate matrixes
randomMatrix = Generator.GenerateRandomMatrix(size, size);
identityMatrix = Generator.GenerateIdentityMatrix(size);
resultVector = Generator.GenerateRandomMatrix(size);
augmentedMatrix = Generator.CreateAugmentedMatrix(size, identityMatrix, randomMatrix);

Console.WriteLine("Random Matrix");
ConsoleWriter.WriteArrayToConsole(size, size, randomMatrix);


inverseMatrix = FindInverseMatrix.InverseOfMatrix(size, augmentedMatrix);

Console.WriteLine("Inverse Matrix");
ConsoleWriter.WriteArrayToConsole(size, size, inverseMatrix);

Console.WriteLine("Result Vector");
ConsoleWriter.WriteArrayToConsole(size, resultVector);

// Calculate solution using x = Inverse(A) * b
solutionVector = CalculateSolution.CalculateSolutionVectorUsingAugmentedMatrix(size, resultVector, inverseMatrix);
watch.Stop();

// Calculate and write solution vector to Console
Console.WriteLine("Solution vector");
ConsoleWriter.WriteArrayToConsole(size, solutionVector);

Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
