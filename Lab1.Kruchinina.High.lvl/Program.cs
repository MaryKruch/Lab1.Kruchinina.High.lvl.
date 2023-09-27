Console.Write("ВВедите c:");
double c = double.Parse(Console.ReadLine());
Console.Write("Введите q:");
double q = double.Parse(Console.ReadLine());
double a = Math.Sqrt((c * c) - (q*q));
Console.WriteLine($"a={a:F2}");
double s = (c * q) / 2;
Console.WriteLine($"s={s:F2}");
