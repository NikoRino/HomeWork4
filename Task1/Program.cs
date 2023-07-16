int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetDegree(int num)
{
    int degree = 1;
    for (i = 1; i <= degree; i++)
    {
        int num = num * i;
    }
    return degree;
}
int num = GetInput("число ");
int degree = GetInput("степень ");
int num = GetDegree(NumDegree);

Console.WriteLine(num);