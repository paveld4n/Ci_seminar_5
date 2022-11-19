// задать массив и найти в нем заданное число

Console.WriteLine("ВВведите искомое число: ");
bool isParsedS = int.TryParse(Console.ReadLine(), out int s);
Console.WriteLine("ВВведите размерность массива: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedS || !isParsedN)
{
    Console.WriteLine("Не правильно введены данные!");
    return;
}

int[] numbers = new int[n];
FillArray (numbers);
PrintArray (numbers);
Console.WriteLine();

Console.WriteLine($"искомое число = {FindNum(numbers, s)}");

bool FindNum (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        return true;
    }
    return false;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

