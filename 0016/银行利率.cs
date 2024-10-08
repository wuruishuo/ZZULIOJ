namespace _0016;

class Program
{
    const double L=2.25;
    static void Main(string[] args)
    {
        string[] input=Console.ReadLine().Split();
        int year=Convert.ToInt32(input[0]);
        double capital=Convert.ToDouble(input[1]);
        double money=Math.Pow((1+L/100),year)*capital;
        Console.WriteLine($"{money:f6}");
    }
}
