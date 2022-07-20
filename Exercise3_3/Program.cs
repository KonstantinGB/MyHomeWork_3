/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Kyb (int n)
{
    int current = 1;
    while( current <= n)
    {
        int sum = current * current * current;
        Console.Write(sum + " ");
        current++;

    }
}

Console.Write("Введите чило больше 1 для возведения в куб чисел от 1 до вашего: ");
int n = Convert.ToInt32(Console.ReadLine());
if ( n > 0) Kyb(n);
else Console.WriteLine ("Вы ввели число меньше 1 ");
