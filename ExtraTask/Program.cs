// Транспонирование - 1

// Задана целочисленная квадратная матрица размером N x N. 
// Требуется транспонировать ее относительно главной диагонали.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N – 
// количество строк и столбцов матрицы. 
// В каждой из последующих N строк записаны N целых чисел – элементы матрицы. 
// Все числа во входных данных не превышают 100 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием 
// исходной матрицы относительно главной диагонали.

// 5
// 3 4 9 1 2           3 8 4 7 5
// 8 2 0 5 1           4 2 7 1 6
// 4 7 4 8 7    -->    9 0 4 3 3
// 7 1 3 3 8           1 5 8 3 7
// 5 6 3 7 0           2 1 7 8 0

Console.WriteLine("Введите число N - количество строк и столбцов матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [N, N];

for (int i = 0; i < N; i++)
{
     for (int j = 0; j < N; j++)
     {
         array [i, j] = new Random().Next(0, 100);
         Console.Write (array[i, j] + "  ");
     }
     Console.WriteLine();
}

for (int i = 0; i < 1; i++)
{
     for (int j = 1; j < N; j++)
     {
         int temp = array [i, j];
         array [i, j] = array [j, i];
         array [j, i] = temp;
     }
}

for (int i = 1; i < 2; i++)
{
     for (int j = 2; j < N; j++)
     {
         int temp = array [i, j];
         array [i, j] = array [j, i];
        array [j, i] = temp;
     }
}

for (int i = 2; i < 3; i++)
{
    for (int j = 3; j < N; j++)
     {
         int temp = array [i, j];
         array [i, j] = array [j, i];
         array [j, i] = temp;
     }
}

for (int i = 3; i < 4; i++)
{
     for (int j = 4; j < N; j++)
     {
         int temp = array [i, j];
         array [i, j] = array [j, i];
         array [j, i] = temp;
     }
}

Console.WriteLine();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write (array[i, j] + " ");
    }

    Console.WriteLine();
}