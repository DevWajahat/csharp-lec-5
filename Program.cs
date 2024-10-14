using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        Math obj = new Math();
        obj.add(4,8);
    }
}

internal class Math
{
    //public int add()
    //{
    //    int a = 5;
    //    int b = 6;
    //    int c = a + b;
    //    return c;
    //}

    //public void add()
    //{
    //    int a = 5;
    //    int b = 6;
    //    int c = a + b;

    //    Console.WriteLine(c);
    //}

    public void add (int a , int b)
    {
        Console.WriteLine(a + b);
    }


}