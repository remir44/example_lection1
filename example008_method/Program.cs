int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 23;
int a2 = 400;
int a3 = 15;
int b1 = 2;
int b2 = 43;
int b3 = 75;
int c1 = 3;
int c2 = 114;
int c3 = 19;

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(max);