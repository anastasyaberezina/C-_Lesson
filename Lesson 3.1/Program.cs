﻿// Вид1

//  void Method1()
//  {
//    Console.WriteLine("Автор ...");
//  }

//  Method1();

//Вид 2

// void Method2(string msg)
// {
//   Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

//Можно добавить дополнительный аргумент

// void Method2(string msg, int count)
// {
//   int i = 0;
//   while(i < count)
//    {
//        Console.WriteLine(msg);
//        i++;
//    }
// }
// Method2("Текст сообщения", 4);

// Вид 3

// int Method3()
// {
//   return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Вид 4

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result+c;
        i++;
    }
    return result;
}
string res = Method4 (10, "Текст");
Console.WriteLine(res); 