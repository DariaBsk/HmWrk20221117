// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matr = new double[m, n];
CreateMatrixRndDouble(matr);
PrintMatrix(matr);

void CreateMatrixRndDouble(double[,] matrix)
{
    double minNum = -100;
    double maxNum = 100;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (maxNum - minNum) + minNum), 1);
        }

    }
}

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) Console.Write($"{matrix[i, matrix.GetLength(1) - 1],5} ");
            else Console.Write($"{matrix[i, j],5} |");
        }
        Console.WriteLine($"|");
    }

}