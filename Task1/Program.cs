Console.WriteLine("Введите пятизначное число");
int fiveDigit = Convert.ToInt32(Console.ReadLine());

if (fiveDigit < 10000 || fiveDigit > 99999)
{
    Console.WriteLine("Введенное число не является пятизначным");
}
else
{
    int[] array = new int[5];

    for (int i = 0; i < array.Length; i++)
    {
        int LastNumber = fiveDigit % 10;
        array[i] = LastNumber;
        fiveDigit = fiveDigit / 10;
    }
    int count =0;
    for (int i = 0; i < array.Length/2; i++)
    {
        if (array[i] == array[array.Length - 1 - i])
        {
           count++;
        }
    }
if( count==array.Length/2)
{
    Console.WriteLine("Число является палиндромом");
}
else
Console.WriteLine("Число не является палиндромом");
}