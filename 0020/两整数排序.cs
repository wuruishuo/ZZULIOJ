namespace _0019;

class Program
{
    static void Main(string[] args)
    {
        string[] input=Console.ReadLine().Split();
        int a=int.Parse(input[0]);
        int b=int.Parse(input[1]);
        int result=a>b?a:b; 
        Console.WriteLine(result);

    }
}
