int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int var = number % 10;
        sum = sum + var;
        number = number / 10;
    }
    Console.WriteLine($"Oтвет: {sum}");
}

int number = GetInput("Введите число: ");
GetSum(number);