int[] array = {1, 2, 4, 68, 15, 3, 99, 15, 68};

int n = array.Length;
int find = 68;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; 
}