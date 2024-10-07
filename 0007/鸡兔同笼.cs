namespace _0007;

class Program
{
    static void Main(string[] args)
    {
    string[] input=Console.ReadLine().Split();
    int heads=int.Parse(input[0]);
    int feet=int.Parse(input[1]);
    int rabbit,chick;
    rabbit=(feet - 2 * heads) / 2;
    chick=heads-rabbit;
    Console.WriteLine("{0} {1}",rabbit,chick);
      
      
       
    }
}
