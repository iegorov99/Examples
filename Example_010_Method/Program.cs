//               0   1   2   3   4   5   6   7   8
int[] array = { 19, 62, 35, 49, 55, 76, 73, 82, 19 };
int n = array.Length;
int find = 19;
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