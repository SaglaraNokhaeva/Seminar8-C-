// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается 
//элемент входных данных.

Console.Clear();
Console.Write("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(rowCount, columnCount, 1, 10);
Console.WriteLine("Начальный массив: ");
PrintArr(array);
int[] arrayTranspon = TransponArray(array, rowCount, columnCount);
Console.WriteLine("Транспонированный массив: ");
PrintArrTrans(arrayTranspon);
int[] sortArray = SortArray(arrayTranspon);
Console.WriteLine("Сортированный массив: ");
PrintArrTrans(sortArray);

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

int[] TransponArray(int[,] inputArr, int rows, int columns)
{
    int[] transponedArray = new int[rows * columns];
    int k = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            transponedArray[k] = inputArr[i, j];
            k++;
        }
    }
    return transponedArray;
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

int[] SortArray(int[] inputArr)
{
    //int[] inputArr = new int[inputArr.Length];
    int l=0;
for (int j = 0; j < inputArr.Length-l; j++)
{
    for (int i = 0; i < inputArr.Length-j-1; i++)
    {
        if (inputArr[i]>inputArr[i+1]) 
        {
            int k=inputArr[i];
            inputArr[i]=inputArr[i+1];
            inputArr[i+1]=k;
        }
        l++;
    }
}
    return inputArr;
};
