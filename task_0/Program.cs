// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int number = EnterData("Введите пятизначное число: ");
int num1 = number/10000;
int num5 = number%10;
int intermediate1 = number/1000;
int num2 = intermediate1%10;
int intermediate2 = number/10;
int num4 = intermediate2%10;
if(num1 == num5 & num2 == num4)
{
    Console.WriteLine($"{number} --> yes");

}
else
{
    Console.WriteLine($"{number} --> no");
}