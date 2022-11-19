// Найдите произведения пар чисел в одномерном массиве.

Console.WriteLine("ВВведите размерность массива: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedN)
{
    Console.WriteLine("Не правильно введены данные!");
    return;
}

int[] numbers = new int[n];
FillArray (numbers);
PrintArray (numbers);

int siz = Vibor(n);
Console.WriteLine($"count = {siz}!");

int[] num = new int[siz];
ProdNumArray(numbers);
PrintArray(num);

int[] ProdNumArray(int[] array)
{
    for (int i = 0; i < siz; i++)
    {
        num[i] = array[i] * array[array.Length-1-i];
    }
    return num;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
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

int Vibor(int n)
{
    if(n % 2 == 0)
    {
        int cot = n/2;
        return cot;
    }
    else
    {
        int cot = n/2+1;
        return cot;
    }
    return -1;
}
