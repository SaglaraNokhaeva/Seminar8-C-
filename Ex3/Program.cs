// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен 
//наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


Console.Clear();
Console.Write("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(rowCount, columnCount, 1, 10);
Console.WriteLine("Начальный массив: ");
PrintArr(array);
Console.WriteLine("Преобразованный массив: ");
Delete(array, rowCount, columnCount);

// if (rowCount == columnCount)
// {
//     ChangeArray(array, rowCount, columnCount);
//     array = ChangeArray(array, rowCount, columnCount);
//     Console.WriteLine("Преобразованный массив: ");
//     PrintArr(array);
// }
// else Console.Write("Преобразовать массив невозможно");


int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
};

void PrintArr(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
};

void Delete(int[,] inputArr, int rows, int columns)
{
    int minimum = inputArr[0, 0];
    int positionRow = 0;
    int positionColumn = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (inputArr[i, j] < minimum)
            {
                 positionRow = i;
                 positionColumn = j;
                minimum = inputArr[i, j];
            }
        }
    }
    for (int i = 0; i < inputArr.GetLength(0); i++)
    {
        for (int j = 0; j < inputArr.GetLength(1); j++)
        {
            if ((i!=positionRow)&&(j!=positionColumn)) Console.Write(" " + inputArr[i, j]);
        }
        Console.WriteLine();
    }

}
// int[,] ChangeArray(int[,] inputArr, int rows, int columns)
// {
//     int[,] changedArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//         {
//             changedArray[i, j] = inputArr[j, i];
//         }
//     return changedArray;
// };
