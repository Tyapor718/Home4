//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int ReadInt(string message)
{
    Console.WriteLine($"{message} ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool validate(int n)
{
    if (n == 0) return false;
    return true;
}
int sum(int k)
{
    int S = 0;
    while (k > 0)
    {
        S = S+ k % 10;
        k=k/10;
    }
    return S;
}
int number = ReadInt("Введите число");
if (validate(number))
{
    int result = sum(number);
    Console.WriteLine($"Сумма цифр {number} равна {result}");
}
else
{
    Console.WriteLine($"Сумма цифр {number} равно нулю");
}