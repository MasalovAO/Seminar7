//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("введите количество строк");
int mLocal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int nLocal = Convert.ToInt32(Console.ReadLine());

double[,] getArray(int mLocal, int nLocal)
{
    double[,] result = new double [mLocal,nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; i++)
        {
            result[i,j] =Convert.ToDouble(new Random().Next(-10, 10));
        }
    }
    return result;
}

void printArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
    Console.WriteLine();
    }
}

double[,] array = getArray(mLocal,nLocal);
printArray(array);

