Console.Write("Kaç Fahrenheit ");

double F = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine( "Celsius : " + (F - 32) * 5.0 / 9.0 );