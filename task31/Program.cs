/// Задать массив из 12 элементов, заполненный случайными числами от -9 до 9. Найти сумму отрицательный и положительных чисел.

int[] numbres = new int[12];

FillArray(numbres);
PrintArray(numbres);

Console.WriteLine();
int sumpositivnum = GetSumPositive(numbres);
// int sumnegativnum = GetSumNegative(numbres); вместо данной строки можно подставить вызов метода сразу в стоку вывода
Console.WriteLine($"Сумма положительных элементов = {sumpositivnum}");
Console.WriteLine($"Сумма отрицателоьных элементов = {GetSumNegative(numbres)}");

(int, int) sum = GetSumPosNeg(numbres); // метод Кортеже - когда метод передает два значения

Console.WriteLine($"Сумма положительных = {sum.Item1}, Сумма отрицательных= {sum.Item2}");

(int, int) GetSumPosNeg(int[] array)
{
    int sumpositiv = 0;
    int sumnegativ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sumpositiv+= array[i];
        }
        else
        {
            sumnegativ+= array[i];
        }
    }
    return (sumpositiv, sumnegativ);
}

int GetSumNegative(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < 0)
        {
            sum+= numbers[i];
        }
    }
    return sum;
}

int GetSumPositive(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > 0)
        {
            sum+= numbers[i];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
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