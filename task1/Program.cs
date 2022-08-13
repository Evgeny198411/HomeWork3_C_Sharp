/*
Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool palindrome(string str)
{
    int n = str.Length;
    for (int i = 0; i < n / 2; i++)
    {
        if (str[i] != str[n - 1 - i]) {return false;}
    }
    return true;
}

Console.WriteLine("Введите число");
string numStr = Console.ReadLine();

Console.WriteLine(palindrome(numStr) ? "Это палиндром": "Это не палиндром");
