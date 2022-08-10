// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
int day_number = Convert.ToInt32(Console.ReadLine());

if (day_number >= 6 && day_number <= 7)
    {
        Console.WriteLine("Этот день является выходным");
    }
else
    {
        Console.WriteLine("Этот день не является выходным");
    }