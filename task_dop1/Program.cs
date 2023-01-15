// Задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию 
// по нему - площадь, периметр, значения углов треугольника в градусах, является ли он 
// прямоугольным, равнобедренным, равносторонним.


Console.WriteLine("Введите стороны a, b, c. Числа должны быть положительными:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a + b <= c || b + c <= a || a + c <= b) Console.WriteLine("Невозможно построить треугольник с введенными сторонами");
else
{
    string[] array = new string[3];
    Gradus(array);
    SP(array);
}


void Gradus(string[] array)
{
    Console.WriteLine("Углы: ");
    double A = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
    Console.WriteLine($"Угол A = {A} градусов");
    double B = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
    Console.WriteLine($"Угол B = {B} градусов");
    double C = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
    Console.WriteLine($"Угол C = {C} градусов");
    if (A == 90 || B == 90 || C == 90) Console.WriteLine("Треугольник является прямоугольным");
}


void SP(string[] array)
{
    if (a == b || a == c || b == c) Console.WriteLine("Треугольник равнобедренный");
    if (a == b && a == c && b == c) Console.WriteLine("Треугольник равноcторонний");
    double P = a + b + c; //периметр треугольника
    double p = P / 2; //полупериметр треугольника
    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //площадь треугольника
    Console.WriteLine($"Периметр треугольника = {P}");
    Console.WriteLine($"Площадь треугольника = {S}");
}
