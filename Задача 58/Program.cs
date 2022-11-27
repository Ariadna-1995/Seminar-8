//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] MultiplyMatrix(int[,] A, int[,] B, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < A.GetLength(1); k++)
            {
                sum += A[i, k] * B[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}
Console.Clear();
Console.WriteLine("Введите кол-во строк первой матрицы: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов первой матрицы: ");
int colsA = int.Parse(Console.ReadLine()!);
int[,] A = GetArray(rowsA, colsA, 1, 5);
PrintArray(A);
Console.WriteLine("Введите кол-во строк первой матрицы: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов первой матрицы: ");
int colsB = int.Parse(Console.ReadLine()!);
int[,] B = GetArray(rowsB, colsB, 1, 5);
PrintArray(B);
int[,] resMatrix = new int[rowsA, colsB];
MultiplyMatrix(A, B, resMatrix);
Console.WriteLine();
PrintArray(resMatrix);





