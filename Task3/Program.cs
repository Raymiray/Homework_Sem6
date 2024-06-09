// Задайте произвольную строку. Выясните, является ли она палиндромом.

bool IsPalindrom(string str)
{
    bool a = false;
    bool b = false;
    int count = 0;
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] == str[str.Length - i - 1])
        {
            a = true;
            if (a)
            {
                count++;
            }
        }
    }
    if (count == str.Length / 2)
    {
        b = true;
    }
    return b;
}

void Print(bool str)
{
    if (str)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

Console.WriteLine("Enter palindrome: ");
string str = Console.ReadLine();;
bool isPalindrom = IsPalindrom(str);
Print(isPalindrom);