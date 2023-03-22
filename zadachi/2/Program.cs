void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Clear();
int[] array = new int[8];
int n = 8;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
PrintArray(array);
