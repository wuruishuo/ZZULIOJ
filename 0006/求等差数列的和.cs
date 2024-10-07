namespace _0006;

class Program
{
    static void Main(string[] args)
    {
        string[] input=Console.ReadLine().Split();
        int[] num=new int[3];
        for (int k = 0; k <input.Length; k++)
        {
            num[k]=Convert.ToInt32(input[k]);
        }
        int sum=0;
        for(int i=num[0];i<=num[1];i+=num[2])
        {
             sum+=i;
        }
        Console.WriteLine(sum);
    }
}
