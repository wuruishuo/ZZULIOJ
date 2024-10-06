using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("请输入三个整数，用空格隔开：");
        string[] inputs = Console.ReadLine().Split();
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);

        // 输出1次幂
        Console.WriteLine($"{a,-9}{b,-9}{c,-9}");
        Console.WriteLine($"{a*a,-9}{b*b,-9}{c*c,-9}");
        Console.WriteLine($"{a*a*a,-9}{b*b*b,-9}{c*c*c,-9}");
    }
}
