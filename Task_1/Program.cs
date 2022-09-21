// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
/* 0,5 7 -2 -0,2
   1 -3,3 8 -9,9
   8 7,8 -7,1 9     */

// Определение метода создания массива вещественных чисел m*n:
double[,] GetArrayRealNumbers(int n, int m)
{
    double[,] array = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
    return array;
}

// Метод вывода массива на консоль:
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Запрос данных о количестве строк и столбцов у пользователя:
Console.Write("Введите количество стобцов (M):");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк (N):");
int n = int.Parse(Console.ReadLine());

double[,] resultArray = GetArrayRealNumbers(n,m);
PrintArray(resultArray);
