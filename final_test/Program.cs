// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно ввести 
//  с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.


using System;

class Program
{
    static void Main()
    {
        // Ввод исходного массива строк
        Console.WriteLine("Введите массив строк через запятую:");
        string input = Console.ReadLine();
        string[] strings = input.Split(',');

        // Вывод исходного массива строк
        Console.WriteLine("Исходный массив строк:");
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }

        // Формирование нового массива строк
        string[] result = new string[strings.Length];
        int resultIndex = 0;
        foreach (string s in strings)
        {
            if (s.Length <= 3)
            {
                result[resultIndex++] = s;
            }
        }

        // Вывод нового массива строк
        Console.WriteLine("Новый массив строк:");
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }
}