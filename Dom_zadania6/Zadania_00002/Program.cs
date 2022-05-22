// Задача 2
// Найти произведение двух матриц

// Сделал сам!!! Используя лекцию, не подглядывал в интернете.

void PrintArray(int[,] matr)                            // Печать матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)                             // Заполнение матрицы, Рандом
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


// метод для умножения матриц
int[,] ProizArray(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];

    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            matrC[i, j] = 0;
            matrC[i, j] += matrA[i, j] * matrB[i, j];
        }
    }
    return matrC;
}


int[,] matrix1 = new int[3, 4];
int[,] matrix2 = new int[3, 4];
FillArray(matrix1);
FillArray(matrix2);
Console.WriteLine();
Console.WriteLine("Дано: ");
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);

int[,] result = ProizArray(matrix1, matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(result);
