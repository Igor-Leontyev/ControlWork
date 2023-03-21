string[] CreateArray(string[] array, int value, int length = 0)
{
    string[] arrTemp = new string[length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            if (arrTemp.Length > 0 && j < arrTemp.Length)
            {
                arrTemp[j] = array[i];
                j++;
            }
            length++;
        }
    }

    if (length > 0 && arrTemp.Length <= 0) return CreateArray(array, value, length);
    return arrTemp;
}

string Entry(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine()?? String.Empty;
}

string[] FullArray(int lenght)
{
    string[] arr = new string[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Entry($"Введите значение{i} массива");
    }
    return arr;
}

int lenght = Convert.ToInt32(Entry("Введите длину массива"));

int value = Convert.ToInt32(Entry("Введите длину строки для отбора"));

string[] arr =  FullArray(lenght);

Console.Write($"[{string.Join(", ", arr)}] -> [{string.Join(", ",CreateArray(arr, value))}]");
