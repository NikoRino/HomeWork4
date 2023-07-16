int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetDegree(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = number * result;
    }
    Console.WriteLine($"Oтвет {result}");
}

int number = GetInput("Введите число ");
int degree = GetInput("Введите степень ");
GetDegree(number, degree);