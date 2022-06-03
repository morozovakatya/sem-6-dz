/* напишите программу кот найдет  точку пересеч
 двух прямых, заданных уравнениями
y = k1* x + b1
y = k2*x + b2
значения k1 k2 b1 b2  пользователь задает сам
*/


double GetValue(string message)
{
    Console.WriteLine(message);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double GetFirstDot(double k1, double k2, double b1, double b2)
{
  double x = (b2 - b1) / (k1 - k2);  
  return x;
}


double GetSecondDot( double k2, double x, double b2)
{
   double y = k2 * x + b2;
   return y;
}


double k1 = GetValue("Введите число k1: ");
double k2 = GetValue("Введите число k2: ");
double b1 = GetValue("Введите число b1: ");
double b2 = GetValue("Введите число b2: ");

double x = GetFirstDot(k1, k2, b1, b2); 
double y = GetSecondDot(k2, x, b2);

Console.WriteLine ($" --> {x}, {y}");

