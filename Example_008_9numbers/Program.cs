//Нахождение максимума из 9 чисел обычным методом ("стихийный способ").
int Max (int arg1, int arg2, int arg3 )
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

int a = 15;
int b = 21;
int c = 39;
int a2 = 197802;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

//int max = Max(a,b,c);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3,b3,c3);
//int maxnumber = Max(max, max2, max3);

int maxnumber = Max(Max(a,b,c), Max(a2, b2, c2), Max(a3,b3,c3));

Console.WriteLine(maxnumber);
