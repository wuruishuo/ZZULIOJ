namespace _0014;

class Program
{
    static void Main(string[] args)
    {
        string[] input=Console.ReadLine().Split();
        float a=float.Parse(input[0]);
        float b=float.Parse(input[1]);
        float c=float.Parse(input[2]);
         double s = (a + b + c) / 2;

        // 使用海伦公式计算面积
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        Console.WriteLine(area.ToString("f2"));
        
    }
}
