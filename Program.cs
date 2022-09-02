// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// double [,] matrix = new double[rows, colums];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     Console.Write("[ ");
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().NextDouble();
//         matrix[i,j] *= 10;
//         matrix[i,j] = Math.Round(matrix[i,j], 1);
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine("]");
// }

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[rows, colums];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     Console.Write("[ ");
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,100);
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine("]");
// }
// Console.WriteLine("Введите индексы");
// int indexRow = Convert.ToInt32(Console.ReadLine());
// int indexColumn = Convert.ToInt32(Console.ReadLine());
// if (indexRow >= rows || indexColumn >= colums) System.Console.WriteLine("Такого значения нет");
// else Console.WriteLine($"Значение с индексом [{indexRow},{indexColumn}] = {matrix[indexRow,indexColumn]}");

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[rows, colums];
// int average = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     Console.Write("[ ");
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(100);
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine("]");
// }
// for (int l = 0; l < matrix.GetLength(1); l++)
// {
//     for (int k = 0; k < matrix.GetLength(0) ; k++)
//     {
//         average += matrix[k,l];
//     }
//     average /= rows;
//     System.Console.WriteLine($"Среднее арифметическое в столбце {l} = {average}");
//     average = 0;
// }
