// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Например:
// 14212 -> нет,
// 12821 -> да,
// 23432 -> да.

// Console.Clear();
void CheckPalindromicNumber(int number)
{
    if (number >= 10000)
    {
        int div1 = number / 10000;
        int remainder1 = number % 10;

        if (div1 == remainder1)
        {
            number = number / 10;
            int div2 = (number / 100) % 10;
            int remainder2 = number % 10;
            if (div2 == remainder2)
                Console.WriteLine("Да");
        }
        else
            Console.WriteLine("Нет");

    }
    else
        Console.WriteLine("Некорректное число!");
}

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);