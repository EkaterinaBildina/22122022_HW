// Напишите программу, которая 
// принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Сейчас мы проверим - Является ли число из 5 знаков палиндромом?");
Console.WriteLine("---------------------------------------------------------------");
Console.Write("Введите исходное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999 || number < 10000) Console.WriteLine("Ошибка ввода числа (5 знаков)");

else
{
    int number1 = NumberFlip(number);
    string result = number == number1 ? "Да" : "Нет";
    Console.WriteLine($"Результат проверки: {result}");

    int NumberFlip(int number1)
    {
        int a1 = number % 10;
        int a2 = (number / 10) % 10;
        int a3 = number / 100 % 10;
        int a4 = number / 1000 % 10;
        int a5 = number / 10000 % 10;
        number1 = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
        return number1;
    }
}