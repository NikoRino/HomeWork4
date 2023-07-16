int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void RandomArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(100);
    }
    Console.WriteLine($"[{String.Join(",", array)}]");
}

int number = GetInput("Введите количество элементов массива: ");
RandomArray(number);