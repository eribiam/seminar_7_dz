// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int colums = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[rows, colums];
bool sign = true;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("[ ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().NextDouble();
        matrix[i,j] *= 10;
        matrix[i,j] = Math.Round(matrix[i,j], 1);
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine("]");
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

