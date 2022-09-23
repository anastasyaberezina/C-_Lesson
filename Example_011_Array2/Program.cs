void FillArray(int[] collection) //дали наименование методу и в качестве аргумента взяли некую коллекцию
{
    int length = collection.Length;
    int index =  0;
    while(index < length)
    {

        collection[index] = new Random().Next(1, 10); //Положили целое случайное число от 1 до 10
        //index=index+1
        index++;
    }
}

void PrintArray(int[] col) //Метод, который будет печатать массив
{
    int count = col.Length;
    int position = 0; //То же, что и index=0
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find) 
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //Определяем новый массив array и укажем что в этом массиве по умолчанию 10 элементов

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);