
 Console.WriteLine("");
 Console.WriteLine("");
 Console.WriteLine("Задача 19");
 Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");

// запрашиваем ввод значений

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10000;
int num2 = (number / 1000) % 10;
int num3 = (number / 10) % 10;
int num4 = (number % 10);


if (number > 99999)
{
    Console.WriteLine("Введите пятизначное число");
}
else if (number < 10000)
{
    Console.WriteLine("Введите пятизначное число");
}
 else if ((num1 == num4) && (num2 == num3))
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
};


 Console.WriteLine("");
 Console.WriteLine("");
 Console.WriteLine("Задача 21");
 Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");


// запрашиваем ввод значений

Console.WriteLine("Введите координату X1");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y1");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z1");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z2");
int Z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((Math.Pow((X2-X1),2)) + (Math.Pow((Y2-Y1),2)) + (Math.Pow((Z2-Z1),2)));
Console.WriteLine($"Расстояние между двумя точками {result}");



 Console.WriteLine("");
 Console.WriteLine("");
 Console.WriteLine("Задача 23");
 Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");


// запрашиваем ввод значений

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <=num; i++)
{
    Console.WriteLine(Math.Pow(i,3));
} 

Console.WriteLine("Программа HomeWork #3 завершена.");
return 0;
