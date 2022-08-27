int a = 2;
int b = 5;
int c = 9;
int d = 6;
int f = 7;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (f > max) max = f;

Console.Write("max = ");
Console.WriteLine(max);