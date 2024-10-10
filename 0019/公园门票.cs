namespace _0018;

class Program
{
    static void Main(string[] args)
    {
       int number=Convert.ToInt32(Console.ReadLine());
       if(number<30)
       {
        Console.WriteLine(50*number);
       }
       else
       {
         Console.WriteLine(48*number);
       }
    }
}
