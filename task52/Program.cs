/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void Task52()
{
    Random random = new Random();
    int rows = random.Next(2,7);
    int columns = random.Next(4,10);
    int [,] array = new int [rows, columns];
    FillArray(array);
    PrintArray(array);

Console.WriteLine("Среднее арифметическое по столбцам");
for (int j = 0; j < columns; j++)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array [i, j];
    }
    Console.Write("");
    Console.Write(sum/rows + "\t");
    
}

void FillArray(int[,] array)
{
    Random random = new Random(); 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        array[i, j] = random.Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Вывод массива " + "\t");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i< rows; i++)
    {
        for (int j = 0; j < columns; j++ )
        Console.Write(array [i, j] + "\t");
        Console.WriteLine();
    }
}
}
Task52();