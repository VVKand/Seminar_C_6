// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью 
// m*n (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. Найти 
// минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.

Console.Write($"Введите количество строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
            for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10, 100);//[1; 10)
        }
    }
}

void MinMax(int[,] matr)
{
    int indmax0 = 0, indmax1 = 0, maxmatr = 0; 
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            if (maxmatr < matr[i, j])
            {
                 maxmatr = matr[i, j];
                 indmax1 = j;
                 indmax0 = i;
            }
            
        }        
    }
        
    int indmin0 = 0, indmin1 = 0, minmatr = maxmatr;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            if (minmatr > matr[i, j]) 
            {
                minmatr = matr[i, j];
                indmin0 = i;
                indmin1 = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"min = {minmatr} в ячейке [{indmin0}, {indmin1}]");
    Console.WriteLine($"max = {maxmatr} в ячейке [{indmax0}, {indmax1}]");
    return;
}

int[,] matrix = new int[a, b];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
MinMax(matrix);