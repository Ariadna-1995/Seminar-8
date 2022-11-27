//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
int[] GetRndArray(int size)
{
    int[] array = new int[size];
    bool Find(int number, int count)
    {
        for(int i = 0; i < count; i++)
        {
            if(array[i] == number) {return true; }
        }
        return false;
    }
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        do
        {
            array[i] = rnd.Next(10, 100);
        }
        while(Find(array[i], i));
    }
    return array;
}
int[,,] Get3DArray(int size)
{
    int[] randomArray = GetRndArray(size*size*size);
    int[,,] array = new int[size, size, size];
    int indexRndArray = 0;
    for(int i = 0; i < size; i++)
    {
        for(int j = 0; j < size; j++)
        {
            for(int k = 0; k < size; k++)
            {
                array[i, j, k] = randomArray[indexRndArray++];
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    int size = array.GetLength(0);
    for(int k = 0; k < size; k++)
    {
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                Console.Write($"{array[i,j,k],2}({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
}
int[,,] newArray = Get3DArray(2);
PrintArray(newArray);