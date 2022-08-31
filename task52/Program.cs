// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] matrix = new int[,]{{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

Console.Write("Среднее арифметическое элементов в каждом столбце: ");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    sum = sum + matrix[j, i];
}

double average = sum/matrix.GetLength(0);

if (j > 0)
{
    Console.Write("; ");
}


Console.Write($"{average:f2}");
}
Console.WriteLine(".");