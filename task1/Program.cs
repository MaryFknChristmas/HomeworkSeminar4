Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow(numberA, numberB));
Console.WriteLine(result);
