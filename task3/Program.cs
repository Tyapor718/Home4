//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] creatArray()
{
    int[] res = new int[8];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(0, 33);
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
int[] mass = creatArray();
PrintArray(mass);

