public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;
        Console.WriteLine("a int");
        Console.WriteLine("b object boxed");
        Console.WriteLine("c int unboxed");
        
    }
}