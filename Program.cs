
// Ввод массива c клавиатуры

string[] InputArray(int size)
{
    string[] array = new string[size];
    Console.Write("Введите элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

// Печать массива

string PrintArray(string[] array)
{
    string print = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        print += (i != (array.Length-1) ? $"{array[i]}, " : $"{array[i]}");
    }
    return print;
}

// Поиск количества элементов (длины нового массива), длина которых меньше либо равна 3 символа

int FindElem (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}


// Создание массива найденной длины из элементов, длина которых меньше либо равна 3 символа

string[] CreateNewArray(string[] array, int count)
{
    int j = 0;
    string[] NewArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            NewArray[j] = array[i];
            j++;
        }
    }
    return NewArray;
}


Console.WriteLine("Введите количество элементов массива: "); // Ограничение размерности исходного массива
int size = Int32.Parse(Console.ReadLine());
if (size > 0)
{
    string[] SourceArray = InputArray(size);
    Console.Write("\nЗаданный массив: ");
    Console.WriteLine(PrintArray(SourceArray));

    int NewSize = FindElem(SourceArray);
    if (NewSize != 0) 
    {
        Console.Write("\nМассив, состоящий только из элементов заданного массива, длина которых меньше либо равна 3: ");
        string[] NewArray = CreateNewArray(SourceArray, NewSize);
        Console.WriteLine(PrintArray(NewArray));
    }

    else Console.WriteLine("\nВ массиве отсутсвуют элементы, длина которых меньше либо равна 3 символа"); 
}

else Console.WriteLine("Введено недопустимое значение");

