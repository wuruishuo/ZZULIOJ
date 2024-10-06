namespace _0003;

class Program
{
    static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int plus, dic, times, div, yu;
        plus = num1 + num2;
        dic = num1 - num2;
        times = num1 * num2;
        div = num1 / num2;
        yu = num1 % num2;
        Console.WriteLine(plus+" "+dic+" "+times+" "+div+" "+yu);
    }
}
