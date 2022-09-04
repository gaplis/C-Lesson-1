// Вид 1 - ничего не возвращают и ничего не принимают

void Method1()
{
    Console.WriteLine ("Автор ...");
}
Method1();

// Вид 2 - ничего не возвращают и что-то принимают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
Method2(msg: "Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2_1("Текст", 4); // 4 - количество раз, которое выводится текст (int count)
Method2_1(msg: "Текст 2", count: 4);
Method2_1(count: 4, msg: "Текст 3");

// Вид 3 - что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4 - что-то возвращают и что-то принимают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // String.Empty - пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z ");
Console.WriteLine(res);

string Method4_2(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res2 = Method4_2(10, "z ");
Console.WriteLine(res);