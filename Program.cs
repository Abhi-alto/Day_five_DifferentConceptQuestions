﻿Console.WriteLine("Enter number 1");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("n = "+n);
Console.WriteLine("m = "+m);
n = n + m;
m = n - m;
n = n - m;
Console.WriteLine("n = " + n);
Console.WriteLine("m = " + m);