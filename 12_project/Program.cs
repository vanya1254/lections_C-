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