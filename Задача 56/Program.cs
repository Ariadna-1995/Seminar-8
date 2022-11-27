//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int GetSumRow(int[,] inArray, int m)
{
    int sum = inArray[m,0];
    for(int i = 1; i < inArray.GetLength(1); i++)
    {
        sum += inArray[m, i];
    }
    return sum;
}
int SmallestAmount(int[,] inArray)
{
    int minsum = 0;
    int CurrentRowSum = GetSumRow(inArray,0);
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        if(CurrentRowSum > GetSumRow(inArray, i))
        {
            minsum = i;
            CurrentRowSum = GetSumRow(inArray, i);
        }
    }
    return minsum;
}

int[,] array = GetArray(4, 4, 1, 10);
PrintArray(array);
Console.WriteLine();
int SmallestSumRow = SmallestAmount(array);
Console.Write($"Строка с наименьшей суммой элементов - {SmallestSumRow}");

