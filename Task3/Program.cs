Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int [] GetTableOfCubes( int n)
{
int [] array = new int [n];
for( int i = 0 ; i < array.Length; i++)
{
    array [i] = (i + 1) * (i + 1) * (i + 1);
}
return array ;
}

int [] result = GetTableOfCubes(n);

PrintArray(result);

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
