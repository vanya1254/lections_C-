int[] array = {1, 2, 54, 57, 94, 32, 65, 76, 94};

int n = array.Length;
int find = 94;

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