// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void CalculatingArithmeticMeanOfCols(int[,] matrix, int row, int col)
// {
//     Console.Write("Среднее арифметическое каждого столбца: ");
//     for (int i = 0; i < row; i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < col; j++)
//         {
//             sum += matrix[j, i];
//         }
//         double arithmeticMean = sum / row;
//         // Условие нужно чтобы в конце последовательности поставить точку.
//         if (i == row - 1) Console.Write($"{arithmeticMean}. ");
//         else Console.Write($"{arithmeticMean}; ");
//     }
// }
void AverageColumns(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (j == array.GetLength(0) - 1)
            {
                average[i] = (average[i] + array[j, i]) / array.GetLength(0);
            }
            else average[i] = average[i] + array[j, i];
        }
    }
    Console.WriteLine(string.Join("; ", average));
}

void PrintMatrix(int[,] matrix, int row, int col)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrix(int row, int col, int max)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(max);
        }
    }
    return arr;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int row = 3;
int col = 5;
int max = 10;
int[,] matrix = CreateMatrix(row, col, max);
PrintMatrix(matrix, row, col);
// CalculatingArithmeticMeanOfCols(matrix, row, col);
AverageColumns(matrix);