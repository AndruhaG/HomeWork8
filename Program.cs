// Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 2 4 1
// 9 5 3 2
// 8 4 4 2


void Zadacha54()
{
    int startNumbers = 1;
    int finishNumbers = 20;
    
    Console.WriteLine("введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.Write("Неотсортированный массив: ");
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();

    Console.Write("Отсортированный массив: ");
    Console.WriteLine();
    ReplacingNumbersInString(array);
    PrintArray(array);
    Console.WriteLine();

    void FillArray(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = new Random().Next(startNumbers, finishNumbers);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }


    void ReplacingNumbersInString(int[,] array)
    {
        for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++)
                    {
                        for (int a = 0; a < columns - 1 - j; a++)
                            {
                                if (array[i, a] < array[i, a + 1])
                                {
                                    int temp = array[i, a];
                                    array[i, a] = array[i, a + 1];
                                    array[i, a + 1] = temp;
                                }
                            }
                    }
            }            
    }
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



void Zadacha56()
{
    int startNumbers = 1;
    int finishNumbers = 20;
    int rows = 3;
    int columns = 4;

    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine();
    PrintArray(array);

    void FillArray(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = new Random().Next(startNumbers, finishNumbers);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    int minSum = 0;
    int stringMinSum = 0;
    for (int j = 0, i = 0; j < columns; j++)
    {

        minSum += array[i, j];
    }
    for (int i = 1; i < rows; i++)
    {
        int sumLine = 0;
        for (int j = 0; j < columns; j++)
        {

            sumLine += array[i, j];
        }
        if (minSum > sumLine)
        {
            minSum = sumLine;
            stringMinSum = i;
        }
    }
    Console.WriteLine($"\nМинимальная сумма {minSum} в строке {stringMinSum + 1}");
}

// Задача 58. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10  9  8  7



void Zadacha58()
{

    
     int rows = 4;
     int columns = 4;
     int number = 1;

    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine();
    PrintArray(array);

    void FillArray(int[,] array)
    {
        int i = 0;
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = number;
            number++;
        }
        for (int n = 1, j = 3; n < 4; n++)
        {
            array[n, j] = number;
            number++;
        }
        for (int n = 3, j = 2; j >= 0; j--)
        {
            array[n, j] = number;
            number++; 
        }
        for (int n = 2, j = 0; n >= 1; n--)
        {
            array[n, j] = number;
            number++; 
        }
        for (int n = 1, j = 1; j <= 2; j++)
        {
            array[n, j] = number;
            number++; 
        }
        for (int n = 2, j = 2; n < 3; n++)
        {
            array[n, j] = number;
            number++; 
        }
        for (int n = 2, j = 1; j > 0; j--)
        {
            array[n, j] = number;
            number++; 
        }
    }
    

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

}










//Zadacha54();
//Zadacha56();
Zadacha58();
