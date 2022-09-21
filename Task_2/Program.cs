// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Определение метода создания массива чисел m*n:
int [,] GetArrayRandomNumbers(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    return array;
}

// Метод вывода массива на консоль:
void PrintArray(int[,] array)
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

// Метод поиска элемента по заданному индексу:
void FindElementInArray(int[,] array, int stringNum, int columnNum)
{
    if (columnNum - 1 > array.GetLength(0) 
        || stringNum - 1 > array.GetLength(1)
        || columnNum < 1
        || stringNum < 1)
    {
        Console.WriteLine($"Значение элемента [{stringNum}, {columnNum}] не существует.");
    }
    else
    {
        Console.WriteLine($"Значение элемента [{stringNum}, {columnNum} ]" + array[columnNum - 1, stringNum - 1]);
    }
}

// Запрос данных о количестве строк и столбцов у пользователя:
Console.Write("Введите количество строк (N): ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество стобцов (M): ");
int m = int.Parse(Console.ReadLine());



// Вызов функций заполнения массива случайными числами и печати его в консоль:
int[,] filledArray = GetArrayRandomNumbers(n, m);
PrintArray(filledArray);
Console.WriteLine();

// Запрос данных у пользователя об индексе искомого элемента:
Console.Write($"Введите номер строки от 1 до {n}: ");
int stringNumber = int.Parse(Console.ReadLine());
Console.Write($"Введите номер столбца от 1 до {m}: ");
int columnNumber = int.Parse(Console.ReadLine());

// Вызов метода поиска по заданному индексу:
FindElementInArray(filledArray, columnNumber, stringNumber);


