/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// Определение метода подсчета среднего арифметического в каждой колонке:
void GetArithmeticMeanOfColumns(int[,] array)
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);

    for (int j = 0; j < width; j++)
    {
        int sum = 0;
        double arithmeticMean = 0; // я не понимаю почему в консоли ответ выходит в int?
        for (int i = 0; i < height; i++)
        {      
            sum += array[i,j];
            arithmeticMean = sum / height;
        }
        Console.Write(arithmeticMean + "\t");
    }       
}

// Инициализация массива:
int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

// Вызов метода подсчета ср.арифметического колонок:
GetArithmeticMeanOfColumns(array);
