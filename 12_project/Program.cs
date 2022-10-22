void Method1 ()
{
    Console.WriteLine("Authtor ");
}

Method1();



void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Message");


void Method21 (string msg, int count)
{
    int i = 1;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(count: 4, msg: "Message");
// Method21("Mesage", 4);



int Method3 ()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);



string Method4 (int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);


string Method42 (int count, string c)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res2 = Method42(10, "z");
Console.WriteLine(res2);



for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}



string text = "Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace (String text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);



int[] arr = {1, 5, 4, 5, 23, 4, 6, 3};

void PrintArray (int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);