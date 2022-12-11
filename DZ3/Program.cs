// Программа, которая вычисляет площадь треугольника по его координатам.

System.Console.WriteLine("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());
double areaTringle = 0.5 * (x3 - x1) * (y2 - y1) - (x2 - x1) * (y3 - y1);
System.Console.WriteLine(areaTringle);