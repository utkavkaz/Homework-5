// задача 1 HARD необязательная. Сгенерировать массив случайных целых чисел 
// размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. 
// Найти минимальное число и его индекс, найти максимальное число и его индекс. 
// Вывести эту информацию на экран.


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2}\t");
        }
        Console.WriteLine();
    }
}

void Max(int[,] array)
{
    int max = array[0, 0];
    int index1 = 0;
    int index2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
                index1 = i;
                index2 = j;
            }
        }
    }
    Console.WriteLine($"Максимальный элемент массива = {max} с индексом [{index1},{index2}]");
}


void Min(int[,] array)
{
    int min = array[0, 0];
    int index3 = 0;
    int index4 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                index3 = i;
                index4 = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент массива = {min} с индексом [{index3},{index4}]");
}

Console.Write("Введите количество строк массива: ");
int heighty = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] myArray = new int[heighty, width];

FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();

Max(myArray);
Console.WriteLine();

Min(myArray);