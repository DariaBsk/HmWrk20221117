// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int min, int max)
{
    Random rnd = new Random();
    int rows = rnd.Next(1, 10);
    int columns = rnd.Next(1, 10);
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {


            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

bool FindElement(int[,] matrix, int rows, int columns)
{
    if (rows > 0 && rows < matrix.GetLength(0) + 2 && columns > 0 && columns < matrix.GetLength(1) + 2) return true; 

    return false;
}

Console.WriteLine("Введите номер строки");
int rowsNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int columnsNum = Convert.ToInt32(Console.ReadLine());
int minimum = -9;
int maximum = 8;

int[,] newMatrix = CreateMatrixRndInt(minimum, maximum);
bool result = FindElement(newMatrix, rowsNum, columnsNum);

Console.WriteLine(result? $"Искомый элемент {newMatrix[rowsNum - 1,columnsNum -1]}" : "Такого элемента не существует");
PrintMatrix(newMatrix);