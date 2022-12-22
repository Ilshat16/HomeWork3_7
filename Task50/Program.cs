// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void SearchElement(int[,] matrix, int row, int col)
{
    if(row > matrix.GetLength(0) - 1 || col > matrix.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else Console.WriteLine($"По координатам [{row}, {col}] находится число {matrix[row, col]}");
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

int yPosition = EnterData("Введите номер строки: ");
int xPosition = EnterData("Введите номер столбца: ");
int row = 5;
int col = 5;
int max = 10;
int[,] matrix = CreateMatrix(row, col, max);
PrintMatrix(matrix, row, col);
SearchElement(matrix, yPosition, xPosition);

