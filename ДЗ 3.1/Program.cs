// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите питизначнее число:");

string numberstring = Console.ReadLine();
int num = Convert.ToInt32(numberstring);

int a = num;
int b = 0;
while (num > 0) 
{ 
    b = b * 10 + num % 10; 
    num /= 10; 
}

if (a == b)
    Console.WriteLine("True");
else
    Console.WriteLine("False");
