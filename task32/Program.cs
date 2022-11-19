// напишите программу замены знака элементов массива 

Console.WriteLine("Введите размерность массива: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if(!isParsedN)
{
    Console.WriteLine("Не правильно введены данные!");
    return;
}
int[] numbers = new int[n];
FillArray (numbers);
PrintArray (numbers);
Console.WriteLine();
ExchangeNum (numbers);
PrintArray (numbers);

void ExchangeNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}