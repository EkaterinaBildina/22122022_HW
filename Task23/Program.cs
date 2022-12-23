// Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// Пример:
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.Write("Введите число N:   ");
int number = Convert.ToInt32(Console.ReadLine());

ThirdPowerTable(number);

void ThirdPowerTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i} | {Math.Pow(i,3)}");
    } 
}
if (number < 1) Console.WriteLine("Проверьте число N (Условие: N > 1)");    
