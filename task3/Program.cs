//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] creatArray(int len, int min, int max)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write($"{array[pos]}  ");
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int S = ReadInt("Введите длину массива");
int MIN = ReadInt("Введите минимум");
int MAX = ReadInt("Введите максимум");
int[] mass = creatArray(S, MIN, MAX);
PrintArray(mass);


