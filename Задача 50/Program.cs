/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет*/

using System;

class Program {
    static void Main(string[] args) 
    {
        int m = 3, n = 4;
        double[,] array = new double[m, n];
        Random random = new Random();

        // заполнение массива случайными числами
        for (int i = 0; i < m; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                array[i, j] = random.NextDouble() * 20 - 10; // числа от -10 до 10
            }
        }

        // вывод массива на экран
        Console.WriteLine("Массив:");
        for (int i = 0; i < m; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                Console.Write($"{array[i, j],8:F2} ");
            }
            Console.WriteLine();
        }

        // ввод позиций элемента
        Console.Write("Введите позицию элемента (например, 1,3): ");
        string[] input = Console.ReadLine().Split(',');
        int row = int.Parse(input[0]) - 1;
        int col = int.Parse(input[1]) - 1;

        // проверка наличия элемента и вывод его значения или сообщения об отсутствии
        if (row >= 0 && row < m && col >= 0 && col < n) 
        {
            Console.WriteLine($"Значение элемента [{row + 1},{col + 1}]: {array[row, col]:F2}");
        } 
        else 
        {
            Console.WriteLine("Такого элемента нет в массиве.");
        }
    }
}