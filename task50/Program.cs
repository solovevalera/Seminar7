// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


int[,] matrix = new int[,]{{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};

 for (int rowNumber = 0; rowNumber < matrix.GetLength(0); rowNumber++)
 {
    for (int columNumber = 0; columNumber < matrix.GetLength(1); columNumber++)
    {
        Console.Write($"{matrix[rowNumber, columNumber]} ");
    }
    Console.WriteLine();
 }

 Console.Write("Ведите индекс строки и колонки через пробел: ");
 string rowAndColumnString = Console.ReadLine();

 string[] rowAndColumnStringElements = rowAndColumnString.Split(' ');

 if (rowAndColumnStringElements.Length ! = 2)
 {
    Console.Write($"должно быть два значения через пробел ");
 return;
 }

 int row = Convert.ToInt32(rowAndColumnStringElements[0]);
 int column = Convert.ToInt32(rowAndColumnStringElements[1]);

 if ((row < 0 || row >= matrix.GetLength(0)) || (column < 0 || column >= matrix.GetLength(1)))
 {
    Console.WriteLine("Элемента с таким индексом в матрице не существует");
    return;
 }

 Console.WriteLine($"В строке {row}, в колонке {column} находится значение: {matrix[row, column]}");