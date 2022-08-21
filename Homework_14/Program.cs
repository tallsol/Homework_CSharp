// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[20];
int size = array.Length;
int count = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
}	
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");


for (int i = 1; i < size; i++)
{
    if (array[i] % 2 == 0) 
    count++;
}
Console.WriteLine($"Количество чётных элементов в массиве: {count}");

