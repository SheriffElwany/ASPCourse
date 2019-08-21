//namespace ExtensionMethods 1st
//namespace ExtensionMethods.Extantions //2nd
namespace System
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static void IsG(this int i)
        {
            Console.WriteLine("ex method");
        }
    }
}
