using System;
using Matrix_Project.Classes;
// See https://aka.ms/new-console-template for more information

var watch = new System.Diagnostics.Stopwatch();

int size = 5;
double[,] randomMatrix = new double[size, size];
double[,] identityMatrix = new double[size, size];
double[,] augmentedMatrix = new double[size, 2 * size];
double[,] inverseMatrix = new double[size, size];
double[] resultVector = new double[size];
double[] solutionVector = new double[size];
watch.Start();
// Generate matrixes
Generator.GenerateRandomMatrix(size, randomMatrix);
Generator.GenerateIdentityMatrix(size, identityMatrix);
Generator.CreateAugmentedMatrix(size, identityMatrix, randomMatrix, augmentedMatrix);
Generator.GenerateResultVector(size, resultVector);
// Write Random Matrix to Console
Console.WriteLine("Random Matrix");
ConsoleWriter.WriteArrayToConsole(size, size, randomMatrix);
// Calculate an Inverse Matrix
Logic.FindInverseOfRandomMatrix(size, augmentedMatrix, inverseMatrix);
Console.WriteLine("Inverse Matrix");
ConsoleWriter.WriteArrayToConsole(size, size, inverseMatrix);


// Write result Vector to Console
Console.WriteLine("Result Vector");
ConsoleWriter.WriteArrayToConsole(size, resultVector);

// Calculate solution using x = Inverse(A) * b
Logic.CalculateSolutionVector(size, resultVector, inverseMatrix, solutionVector);
watch.Stop();

// Calculate and write solution vector to Console
Console.WriteLine("Solution vector");
ConsoleWriter.WriteArrayToConsole(size, solutionVector);

Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
