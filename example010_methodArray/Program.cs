int[] array = { 1, 12, 31, 41, 15, 66, 17, 8, 16 };

int n = array.Length;
int find = 16;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}