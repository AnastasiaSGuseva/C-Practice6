// Задача 41
//  Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа: ");
int [] array = new int [M];
int count = 0;

for (int i = 0; i < M; i++)
{
    array [i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
        count++;    
}

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Количество чисел больше нуля: " + count);