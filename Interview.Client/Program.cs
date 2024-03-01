namespace Interview.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Test()
        {

        }
    }

    class Class1A: Interview.Library.Class1
    {
        static void Test()
        {
            
        }

        void Call()
        {
            //members of Class1 i can call here
        }
    }
}
