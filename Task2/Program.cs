// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
int b1 = getValues("b1", "A");
int k1 = getValues("k1", "B");
int b2 = getValues("b2", "C");
int k2 = getValues("k2", "D");

double x = getX(b1, k1, b2, k2);
double y1 = getY(k1, b1, x);
double y2 = getY(k2, b2, x);

Console.Write("(" + y1 + "; " + y2 + ")");

//--- Methods ---

int getValues(string valueName, string pointName)
{
    Console.Write($"Enter value {valueName} point {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double getX(int b1, int k1, int b2, int k2)
{
    double a = b2 - b1;
    double b = k1 - k2;
    return a / b;
}

double getY(int k, int b, double x)
{
    return (k * x + b);
}