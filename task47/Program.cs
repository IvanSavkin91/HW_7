/*  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

void Task47()
{
    Random random = new Random();
    int rows = random.Next(2,7);
    int columns = random.Next(4,10);
    double [,] array = new double [rows, columns];
    FillArray(array);
    PrintArray(array);

    void FillArray(double[,] array)
    {
        Random random = new Random(); 
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 1);
            }
        }
    }

    void PrintArray(double[,] array)
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
Task47();