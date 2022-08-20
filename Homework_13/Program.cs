// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 88, 41, 9 -> [1, 2, 5, 7, 19, 88, 41, 9]
// 6, 1, 33, 90, 24, 0, 11, 59 -> [6, 1, 33, 90, 24, 0, 11, 59]

Console.WriteLine("Введите массив: ");

    int [] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

Console.WriteLine($"Массив: [{String.Join(", ", array)}]");