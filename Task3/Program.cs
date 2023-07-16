int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void RandomArray(int number, int start, int end)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    Console.WriteLine($"[{String.Join(",", array)}]");
}

int number = GetInput("Введите количество элементов массива: ");
int start = GetInput("Введите начало диапозона: ");
int end = GetInput("Введите конец диапозона: ");
RandomArray(number, start, end);