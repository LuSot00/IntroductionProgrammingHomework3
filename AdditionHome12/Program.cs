// Home_12. Дано с клавиатуры целое число x. Пользуясь только операцией умножения, получить:

// а) x^4 за две операции; б) x^6 за три операции;

// в) x^7 за четыре операции; г) x^8 за три операции;

// д) x^9 за четыре операции; е) x^10 за четыре операции;

// ж) x^13 за пять операций; з) x^15 за пять операций;

// и) x^21 за шесть операций; к) x^28 за шесть операций;

// л) x^64 за шесть операций.


Console.WriteLine("Введите целое число: ");
int x = Convert.ToInt32(Console.ReadLine());

int x1 = x;
x1 = x1 * x1;
x1 = x1 * x1;
Console.WriteLine("а)" + x1);
Console.WriteLine();

int x2 = x;
x2 = x2 * x2 * x2;
x2 = x2 * x2;
Console.WriteLine("б)" + x2);
Console.WriteLine();

int x3 = x;
x3 = x3 * x3;
x3 = x3 * x3 * x3;
x3 = x3 * x;
Console.WriteLine("в)" + x3);
Console.WriteLine();

int x4 = x;
x4 = x4 * x4;
x4 = x4 * x4;
x4 = x4 * x4;
Console.WriteLine("г)" + x4);
Console.WriteLine();

int x5 = x;
x5 = x5 * x5 * x5;
x5 = x5 * x5 * x5;
Console.WriteLine("д)" + x5);
Console.WriteLine();

int x6 = x;
x6 = x6 * x6;
x6 = x6 * x6;
x6 = x6 * x;
x6 = x6 * x6;
Console.WriteLine("е)" + x6);
Console.WriteLine();

int x7 = x;
x7 = x7 * x7 * x7;
x7 = x7 * x7;
x7 = x7 * x7;
x7 = x7 * x;
Console.WriteLine("ж)" + x7);
Console.WriteLine();

int x8 = x;
x8 = x8 * x8;
x8 = x8 * x8;
x8 = x8 * x;
x8 = x8 * x8 * x8;
Console.WriteLine("з)" + x8);
Console.WriteLine();

int x9 = x;
x9 = x9 * x9 * x9;
x9 = x9 * x9;
x9 = x9 * x;
x9 = x9 * x9 * x9;
Console.WriteLine("и)" + x9);
Console.WriteLine();

int x10 = x;
x10 = x10 * x10 * x10;
x10 = x10 * x10;
x10 = x10 * x;
x10 = x10 * x10;
x10 = x10 * x10;
Console.WriteLine("к)" + x10);
Console.WriteLine();

decimal x11 = x;
x11 = x11 * x11;
x11 = x11 * x11;
x11 = x11 * x11;
x11 = x11 * x11;
x11 = x11 * x11;
x11 = x11 * x11;
Console.WriteLine("л)" + x11);
Console.WriteLine();