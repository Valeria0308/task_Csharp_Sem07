// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Main()
{
    int rows = ReadInt("Введите количество строк: ");
    int cols = ReadInt("Ведите количество стобцов: ");
    double[,] matrix = FillMatrix(rows, cols, -10, 10);
    PrintMatrix(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    double[,] tempMatrix = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 1);
        }
    }
    return tempMatrix;
}
void PrintMatrix(double[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Main();