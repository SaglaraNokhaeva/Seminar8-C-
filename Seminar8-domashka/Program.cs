Console.Clear();
Console.WriteLine("Введите номер задачи (54, 56 или 58) для проверки:");
int num = int.Parse(Console.ReadLine());
if (num == 54) Task54();
else if (num == 56) Task56();
else if (num == 58) Task58();
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
    Console.WriteLine("Номер строки с наименьшей суммой элементов: "+ minSummRow);


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
        for (int i = 0; i < rows; i++)
        {
            summedArray[i] = 0;
            for (int j = 0; j < columns; j++)
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

    int MinElement(int[] inputArray)
    {
        int minElem = inputArray[0];
        int k = 0;
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            if (inputArray[i] < minElem)
            {
                k = i;
                minElem = inputArray[i];
            }
        };
        return k;
    };
};
void Task58()
{
    //Задача 58: Задайте две матрицы. Напишите программу, которая будет 
    //находить произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18


    Console.Clear();
    Console.Write("Введите количество строк первого массива: ");
    int rowCountFirst = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов первого массива: ");
    int columnCountFirst = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество строк второго массива: ");
    int rowCountSecond = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов второго массива: ");
    int columnCountSecond = Convert.ToInt32(Console.ReadLine());

    int[,] arrayFirst = FillArray(rowCountFirst, columnCountFirst, 1, 10);
    Console.WriteLine("Первый массив: ");
    PrintArr(arrayFirst);
    int[,] arraySecond = FillArray(rowCountSecond, columnCountSecond, 1, 10);
    Console.WriteLine("Второй массив: ");
    PrintArr(arraySecond);

    MyltiplayArray(arrayFirst, arraySecond);
   
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

};

void MyltiplayArray(int[,] inputArrFirst, int[,] inputArrSecond)
{
    if ((inputArrFirst.GetLength(0) == inputArrSecond.GetLength(0)) && (inputArrFirst.GetLength(1) == inputArrSecond.GetLength(1)))
    {
        Console.WriteLine("Произведение массивов");
        int[,] MyltiArr = new int[inputArrFirst.GetLength(0), inputArrFirst.GetLength(1)];
        for (int i = 0; i < inputArrFirst.GetLength(0); i++)
        {
            for (int j = 0; j < inputArrFirst.GetLength(1); j++)
            {
                Console.Write(" " + inputArrFirst[i, j] * inputArrSecond[i, j]);
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Невозможно выполнить произведение матриц.");
}
