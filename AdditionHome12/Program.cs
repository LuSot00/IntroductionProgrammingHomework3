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

