int a = 3;
int b = 1;
int c = 7;
int d = 2;
int e = 5;

int max = a;
    //a > max
if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;
Console.Write(max);