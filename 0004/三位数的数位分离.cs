namespace _0004;

class Program
{
    static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int ge, shi, bai;
        bai = num / 100;
        shi = (num % 100) / 10;
        ge = num % 10;
        Console.WriteLine(ge+" "+shi+" "+bai);
    }
}
