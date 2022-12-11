// Программа, которая считает сколько чисел больше 0 ввёл пользователь.

System.Console.WriteLine("Введите числа: ");
double[] num = new double[5];
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    num[i] = Convert.ToDouble(Console.ReadLine());
    if (num[i] > 0) count++;
}
System.Console.WriteLine($"{string.Join(", ", num)} -> {count}");



