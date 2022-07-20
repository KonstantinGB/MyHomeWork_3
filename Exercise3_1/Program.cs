/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool Polindrom(int num)
{
    if((num / 1000) == (num % 10 * 10) + (num %100 / 10)) return true;
    else  return false;
}

    
Console.Write("Введите 5-ти значное число для проверки является ли оно полиндромом: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000) 
{
    bool polindrom = Polindrom(num);
    Console.Write(polindrom);
}
else  Console.Write(" Вы ввели не 5-ти значное число");

