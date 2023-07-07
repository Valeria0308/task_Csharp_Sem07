// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Main()
{
    int rows = ReadInt("Введите количество строк: ");
    int cols = ReadInt("Ведите количество стобцов: ");
    int[,] matrix = FillMatrix(rows, cols, 0, 10);
    PrintMatrix(matrix);
    ReturnElement(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
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

void ReturnElement(int[,] matrix)
{
    int i = ReadInt("Введите индекс строки: ");
    int j = ReadInt("Ведите индекс столбца: ");
    if (i >= matrix.GetLength(0) || j >= matrix.GetLength(1))
    {
        System.Console.WriteLine("Такого элемента нет");
    }
    else
    {
        System.Console.Write(matrix[i, j]);
    }
}

Main();