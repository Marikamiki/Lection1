int a = 1;
int b = 2;
int c = 6;
int g = 8;
int e = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (g > max) max = g;
if (e > max) max = e;

Console.Write ("max = ");
Console.WriteLine (max);