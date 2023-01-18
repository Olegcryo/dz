//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int a = 2;
int b = 3;
int c = 7;
int max = a;
if (a < b) max = b;
if (a < c) max = c;
if (b < a) max = a;
if (b < c) max = c;
if (c < a) max = a;
if (c < b) max = b;
Console.WriteLine(max);

int a1 = 44;
int b1 = 5;
int c1 = 78;
int max1 = a;
if (a1 < b1) max1 = b1;
if (a1 < c1) max1 = c1;
if (b1 < a1) max1 = a1;
if (b1 < c1) max1 = c1;
if (c1 < a1) max1 = a1;
if (c1 < b1) max1 = b1;
Console.WriteLine(max1);

int a2 = 22;
int b2 = 3;
int c2 = 9;
int max2 = a;
if (a2 < b2) max2 = b2;
if (a2 < c2) max2 = c2;
if (b2 < a2) max2 = a2;
if (b2< c2) max2 = c2;
if (c2 < a2) max2 = a2;
if (c2 < b2) max2 = b2;
Console.WriteLine(max2);