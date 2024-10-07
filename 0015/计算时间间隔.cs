namespace _0015;

class Program
{
    static int time (int num1,int num2,int num3,int num4,int num5,int num6)
    {
      return num1*10*60*60+num2*60*60+num3*10*60+num4*60+num5*10+num6;
    }
    static void Main(string[] args)
    {
       string time1=Console.ReadLine();
       int a1=Convert.ToInt32(time1[0]);
       int a2=Convert.ToInt32(time1[1]);
       int a3=Convert.ToInt32(time1[3]);
       int a4=Convert.ToInt32(time1[4]);
       int a5=Convert.ToInt32(time1[6]);
       int a6=Convert.ToInt32(time1[7]);
       string time2=Console.ReadLine();
       int b1=Convert.ToInt32(time2[0]);
       int b2=Convert.ToInt32(time2[1]);
       int b3=Convert.ToInt32(time2[3]);
       int b4=Convert.ToInt32(time2[4]);
       int b5=Convert.ToInt32(time2[6]);
       int b6=Convert.ToInt32(time2[7]);
       int interval=time(b1,b2,b3,b4,b5,b6)-time(a1,a2,a3,a4,a5,a6);
       Console.WriteLine(interval);
       
    }
}

// using System;

// class Program
// {
//     static void Main()
//     {
//         // 读取第一个时间点
//         string time1 = Console.ReadLine();
//         // 读取第二个时间点
//         string time2 = Console.ReadLine();

//         // 计算两个时间点之间的时间间隔（以秒为单位）
//         int intervalInSeconds = CalculateTimeDifferenceInSeconds(time1, time2);

//         // 输出时间间隔
//         Console.WriteLine(intervalInSeconds);
//     }

//     static int CalculateTimeDifferenceInSeconds(string time1, string time2)
//     {
//         // 将时间字符串分割为小时、分钟和秒
//         var parts1 = time1.Split(':');
//         var parts2 = time2.Split(':');

//         // 将小时、分钟和秒转换为整数
//         int hours1 = int.Parse(parts1[0]);
//         int minutes1 = int.Parse(parts1[1]);
//         int seconds1 = int.Parse(parts1[2]);
//         int hours2 = int.Parse(parts2[0]);
//         int minutes2 = int.Parse(parts2[1]);
//         int seconds2 = int.Parse(parts2[2]);

//         // 将时间转换为总秒数
//         int totalSeconds1 = hours1 * 3600 + minutes1 * 60 + seconds1;
//         int totalSeconds2 = hours2 * 3600 + minutes2 * 60 + seconds2;

//         // 计算时间间隔
//         return totalSeconds2 - totalSeconds1;
//     }
// }

