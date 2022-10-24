
Console.WriteLine("Введите пятизначное число");
bool isParsedNum = int.TryParse(Console.ReadLine(), out int number);

int count = CountDigit(number);

if (!isParsedNum || count != 5)
{
    Console.WriteLine("Ошибка! Веденны не корректные данные ");
    return;
}

int[] array = AddDigitsToArray(number, count);

bool result = PalindromeCheck(array);

if (result)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
int CountDigit(int number)
{
    int count;
    for (count = 0; number != 0; count++)
    {
        number /= 10;
    }
    return count;
}
int[] AddDigitsToArray(int number, int size)
{
    int[] array = new int[size];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }
    return array;
}
bool PalindromeCheck(int[] array)
{
    bool result = false;

    for (int i = 0; i < array.Length / 2; i++)
    {
        if (array[i] == array[array.Length - 1 - i])
        {
            result = true;
        }
        else
        {
            result = false;
        }
    }
    return result;
}