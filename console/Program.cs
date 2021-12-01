namespace Kang.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The solution is born!");
            Test1();
        }

        private static void Test1()
        {
            System.Console.WriteLine(Kang.Core.ContentNode.Builder.Create().SetTitle("Test Node").Build());
        }
    }
}