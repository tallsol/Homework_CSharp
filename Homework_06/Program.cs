// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int n = number.Length;

if (n < 3)
    { 
        Console.WriteLine("В числе меньше трёх цифр");
    }
else 
    { 
        Console.WriteLine($"Третья цифра: {number[2]}"); 
    }