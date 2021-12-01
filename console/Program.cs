using MsConsole = System.Console;

namespace Kang.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            MsConsole.WriteLine("The solution is born!");
            Test1();
        }

        private static void Test1()
        {
            MsConsole.WriteLine(Kang.Core.ContentNode.Builder.Create().SetTitle("Test Node").Build());
        }
    }
}