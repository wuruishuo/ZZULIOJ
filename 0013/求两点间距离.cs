namespace _0013;

class Program
{
    static void Main(string[] args)
    {
        string[] input=Console.ReadLine().Split();
        float x1=Convert.ToSingle(input[0]);
        float y1=Convert.ToSingle(input[1]);
        float x2=Convert.ToSingle(input[2]);
        float y2=Convert.ToSingle(input[3]);
        double length_gen=(x1-x2)*(x1-x2)+(y1-y2)*(y1-y2);
        Console.WriteLine(Math.Sqrt(length_gen).ToString("f2"));
    }
}
