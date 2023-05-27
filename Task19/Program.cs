/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
P/S Не стал ограничивать проверку 5ю числами
*/
Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine()!;
int i = 0;
while (i < (number.Length/2))
{
if(Convert.ToInt32(number[i].ToString()) == Convert.ToInt32(number[number.Length-(1+i)].ToString()))
   {
    i++;
    }
    else
    goto Negative;
}
Console.WriteLine("Число является полиндромом");
return; // делал через break; но почему то через break у меня не сработало. Задать вопрос?

Negative:
Console.WriteLine("Число не является палиндромом");