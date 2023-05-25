int[] array = { 13, 42, 53, 4, 85, 4, 66, 47, 28 };

int n = array.Length;
int find = 4;

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