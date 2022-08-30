// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3


Console.WriteLine("Введите массив: ");
int[] array = new int[5];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Массив: [{String.Join("; ", array)}]");


for (int i = 0; i < array.Length; i++)
{
	if (array[i] > 0) count++;
}

Console.WriteLine($"Количество введённых чисел больше нуля - {count}");