﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}



int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(max);