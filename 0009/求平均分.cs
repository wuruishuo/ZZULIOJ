namespace _0009;

class Program
{
    static void Main(string[] args)
    {
        string[] input=Console.ReadLine().Split();
        int[] groce=new int[input.Length];
        int sum=0;
        for (int i = 0; i < input.Length; i++)
        {
            groce[i]=int.Parse(input[i]);
            sum+=groce[i];
        }
        double ave=(double)sum/input.Length;
        Console.WriteLine(ave.ToString("f2"));
    }
}
