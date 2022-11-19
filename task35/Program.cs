//  Задать одномерный массив из 123 чисел. Найти количество элементов значения которых лежат в отрезке от 10 до 99



int[] numbers = new int[123];
FillArray (numbers);
PrintArray (numbers);
Console.WriteLine();
int count = FindNum(numbers);

Console.WriteLine($"количество элементов = {count}");

int FindNum (int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 & array[i] <= 99)
        {
            res++;
        }
    }
    return res;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-1000, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}