// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int[5];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-5, 6);
}
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

for (int i = 1; i < array.Length; i += 2)
{
    result = result + array[i];
}

Console.WriteLine($"Сумма нечётных элементов массива= {result}");
