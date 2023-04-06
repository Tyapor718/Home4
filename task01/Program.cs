//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int ReadInt(string message)
{
    Console.WriteLine($"{message} ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool validate(int n, int f)
{
    if (n == 0 || f == 0) return false;
    return true;
}
int Degree(int K, int F)
{
    int res = 1;
    for (int i = 0; i < F; i++)
    {
        res = res * K;
    }
    return res;
}

int number1 = ReadInt("Введите первое число");
int number2 = ReadInt("Введите второе число");
if (validate(number1,number2))
{
     int result = Degree(number1, number2);
     Console.WriteLine($"Число {number1} в степени {number2} равно {result}");
}
else
{
Console.WriteLine($"Число {number1} в степени {number2} равно нулю");
}
