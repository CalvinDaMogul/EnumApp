using System;

namespace EnumApp
{
   public class EnumTest
{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    static void Main()
    {
        Console.Write("Hello World!");
        Console.ReadLine();

        int x = (int)Day.Sun;
        int y = (int)Day.Fri;
        int a = (int)Day.Tue;
        int b = (int)Day.Wed;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
        Console.WriteLine("Tue = {0}", a);
        Console.WriteLine("Wed = {0}", b);
    }
}
}