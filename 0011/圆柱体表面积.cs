namespace _0011;

class Program
{
    const double PI=3.14159;
    static void Main(string[] args)
    {
       string[] input=Console.ReadLine().Split();
       double r=double.Parse(input[0]);
       double h=double.Parse(input[1]);
       double s=2*PI*r*r+2*PI*r*h;
       Console.WriteLine(s.ToString("f2"));

    }
}
