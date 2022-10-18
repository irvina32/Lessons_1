int [] array = {1, 12, 23, 25, 34, 114, 13, 78 };

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}