Console.Clear();
Console.WriteLine("Введите номер задачи (54, 56 или 52) для проверки:");
int num = int.Parse(Console.ReadLine());
if (num == 54) Task54();
else if (num == 56) Task56();
else if (num == 52) Task52();
else Console.WriteLine("Дополнительных задач не решала.");

void Task54()
{
    // Задача 54: Задайте двумерный массив. 
    //Напишите программу, которая упорядочит по убыванию элементы каждой строки 
    //двумерного массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2


    Console.Clear();
    Console.Write("Введите количество строк: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(rowCount, columnCount, 1, 10);
    Console.WriteLine("Начальный массив: ");
    PrintArr(array);
    int[,] sortArr = SortArray(array);
    Console.WriteLine("Сортированный массив: ");
    PrintArr(sortArr);


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

    int[,] SortArray(int[,] inputArr)
    {
        for (int l = 0; l < inputArr.GetLength(0); l++)
        {
            for (int j = 0; j < inputArr.GetLength(1); j++)
            {
                for (int i = 0; i < inputArr.GetLength(1) - j - 1; i++)
                {
                    if (inputArr[l, i] < inputArr[l, i + 1])
                    {
                        int k = inputArr[l, i];
                        inputArr[l, i] = inputArr[l, i + 1];
                        inputArr[l, i + 1] = k;
                    }
                }
            }
        }
        return inputArr;
    };
};

void Task56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. 
    //Напишите программу, которая будет находить строку с наименьшей суммой 
    //элементов.

    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7

    // Программа считает сумму элементов в каждой строке и выдаёт 
    //номер строки с наименьшей суммой элементов: 1 строка

    Console.Clear();
    Console.Write("Введите количество строк: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(rowCount, columnCount, 1, 10);
    Console.WriteLine("Начальный массив: ");
    PrintArr(array);
    int[] arraySumm = SummArray(array, rowCount, columnCount);
    Console.WriteLine("Суммированный массив: ");
    PrintArrTrans(arraySumm);
    int minSummRow = MinElement(arraySumm);
    int m = MinElement(arraySumm);
 Console.WriteLine(m);


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

    int[] SummArray(int[,] inputArr, int rows, int columns)
    {
        int[] summedArray = new int[rows];
        for (int i = 0; i < columns; i++)
        {
            summedArray[i] = 0;
            for (int j = 0; j < rows; j++)
            {
                summedArray[i] = summedArray[i] + inputArr[i, j];
            }
        }
        return summedArray;
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

    void PrintArrTrans(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write(" " + inputArray[i]);
        }
        Console.WriteLine();
    };

    int MinElement(int[] inputArray);
    {
        int minElem = inputArray[0];
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            int k = i;
            if (inputArray[i] < minElem)
            {
                minElem = inputArray[i];
            }
        };
        return k;
    };
};
    void Task52()
    {
        //Задача 52. Задайте двумерный массив из целых чисел. 
        //Найдите среднее арифметическое элементов в каждом столбце.

        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



        Console.Clear();
        Console.Write("Введите количество строк: ");
        int rowCount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int columnCount = Convert.ToInt32(Console.ReadLine());

        int[,] array = FillArray(rowCount, columnCount, 1, 10);
        Console.WriteLine("Массив: ");
        PrintArr(array);

        for (int j = 0; j < columnCount; j++)
        {
            double summa = 0;
            for (int i = 0; i < rowCount; i++)
            {
                summa = summa + array[i, j];
            }
            double averageArif = summa / rowCount;
            Console.Write(Math.Round(averageArif, 2) + "; ");
        }

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
        }
    }