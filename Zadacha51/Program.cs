//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] getArray(int m, int n)
{
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(0, 10);
        }
    }
    return result;
}


void printArray(int[,] inArray)
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

void findAverage(int[,] newArray)
{   
    //double[,] result = new double [m,n];
    
    for (int j = 0; j < newArray.GetLength(1); j++)
    {   
        double sum = 0;
        for (int i = 0; i < newArray.GetLength(0); i++)
        {   
            
            sum = sum + newArray[i,j];
                    
        }
        double average = sum/m;
        Console.Write($"{average}; ");   
    }
     
}

int[,] array = getArray(m,n);
printArray(array);
Console.WriteLine();
findAverage(array);
Console.WriteLine();