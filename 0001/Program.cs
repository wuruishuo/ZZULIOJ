namespace _0001;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("换行输入/不换行输入");
    int  a = Convert.ToInt32(Console.ReadLine());
    int  b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("换行输入:"+(a+b));

    string shuzi = Console.ReadLine();
    int c = Convert.ToInt32(shuzi.Substring(0, shuzi.IndexOf(" ")));
    int d = Convert.ToInt32(shuzi.Substring(shuzi.LastIndexOf(" ")));
    Console.WriteLine("不换行输入:"+(c+d));
    }
}
