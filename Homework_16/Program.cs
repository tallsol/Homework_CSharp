// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double[7];
double minDigit = 0;
double maxDigit = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-13, 14);
}
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minDigit)
    {
        minDigit = array[i];
    }

    if (array[i] > maxDigit)
    {
        maxDigit = array[i];
    }
}
double result = minDigit + maxDigit;

Console.WriteLine($"Разница между минимальным и максимальным элементом = {result}");
