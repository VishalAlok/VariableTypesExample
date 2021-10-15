using System;

namespace Variables
{
    class Program
    {
        readonly int X;// readonly variable initialisation (only at class level, and always non static)
        static void Main(string[] args)
        {
            int a = Program2.MyConstant; //int a Local variable 
            Console.WriteLine("Hello World!");
        }

        public Program(int x)
        {
            this.X = x; // readonly gets value, its gets initialized only in constructor, or during declaration
        }
    }
    class Program2
    {
        internal const int MyConstant = 10; // (By Default Static) Constant variable , initializing is mandatory
        public static void hello()
        {

        }
    }
}
