int [] array = {1, 52, 95, 26, 4, 52, 14 };

int n = array.Length;
int find = 52;

int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
    Console.WriteLine(index);
    break;
    }
//index = index + 1;
index++;
}
