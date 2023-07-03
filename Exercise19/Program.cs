// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Для усложенения: модифицировать программу из 19 задания и сделать так, чтобы проверялись не только цифры, но и строчки.
// Или любую задачку из 400 задач по C#: https://serg40in.ru/reshaem-400-zadach-na-c/


Console.WriteLine("Введите пятизначное комбинацию символов: ");
string stringNumber = Console.ReadLine();

if (stringNumber.Length == 5)
{
    if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
    {
        Console.WriteLine($"Комбинавция символов {stringNumber} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Комбинавция символов {stringNumber} не является палиндромом");
    }
}
else
{
    Console.WriteLine($"Комбинавция символов {stringNumber} не состоит из пяти символов");
}