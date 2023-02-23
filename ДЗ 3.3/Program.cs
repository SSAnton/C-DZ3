//Задача 23: Напишите программу, которая принимает 
//на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

void FillArray(int[] arr)
{
    int len = arr.Length;
    int i = 0;
    while (i<len)
    {
        arr[i] = i + 1;
        i++;
    }
}

void PrintArray(int[] arr)
{
    int len = arr.Length;
    int i = 0;
    while (i<len)
    {
        Console.WriteLine(arr[i]);
        i++;
    }
}

void CubeArray(int[] arr)
{
    int len = arr.Length;
    int i = 0;
    while (i<len)
    {
        arr[i] = arr[i] * arr[i] * arr[i];
        i++;
    }
}

FillArray(array);
//PrintArray(array);
CubeArray(array);
PrintArray(array);
