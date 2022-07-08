Task2();
void Task2()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Во введенном числе сумма цифр равна " + Summa(number));
}

int Summa(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number%10;
        number = number/10;
    }
    return sum;
}