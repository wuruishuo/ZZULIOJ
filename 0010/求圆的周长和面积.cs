namespace _0010;

class Program
{
    const double PI=3.14159;
    static void Main(string[] args)
    {
        int r=Convert.ToInt32(Console.ReadLine());
        double perimete=2*PI*r;
        double area=PI*r*r;
        Console.WriteLine($"{perimete:f2} {area:f2}");
    }
}
