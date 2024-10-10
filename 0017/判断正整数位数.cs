namespace _0017;

class Program
{
    static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine()); 
        int number=(int)Math.Log10(num)+1;
        Console.WriteLine(number.ToString("f0"));

        string num1=Console.ReadLine();
        Console.WriteLine(num1.Length);

    }
}
