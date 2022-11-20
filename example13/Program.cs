// md 1
// void Method1()
// {
//     Console.WriteLine("Автор Бурлаков");
// }
// Method1(); // вызываем метод так, обязательно со скобками

// метод 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21(msg: "Текст", count 4); // явно указывать какому элементу какую конструкцию
// Method21(count 4, msg: "Новый текст");

//метод 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// метод 4
// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty; // либо "";
//     while(i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);



string Method4(int count, string c)
{
    string result = String.Empty; // либо "";
    for(int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);