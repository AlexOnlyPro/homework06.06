// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] array = new int [8];

for (int i = 0; i < 8; i++)
    if (i == 0) 
    {
        System.Console.WriteLine("Введите первое число массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    else
    {
        System.Console.WriteLine("Введите следующее число массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
   

for (int i = 0; i < 8; i++)
    System.Console.Write(array[i] + " ");