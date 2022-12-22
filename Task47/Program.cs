// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintDoubleMatrix(double[,] matrix, int row, int col)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write("{0:F1} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

double[,] CreateDoubleMatrix(int row, int col, int max)
{
    double[,] arr = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().NextDouble() * max;
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

int row = EnterData("Введите количество строк: ");
int col = EnterData("Введите количество столбцов: ");
int max = 10;
double[,] matrix = CreateDoubleMatrix(row, col, max);
PrintDoubleMatrix(matrix, row, col);