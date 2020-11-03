using System;
using testclass2.Chap6_5;

namespace Testclass1
{
    class MainClass
    {
        public void PrintOne()
        {
            Console.WriteLine("1");
        }

        static void Main()
        {
            // MainClass test = new MainClass();
            // test.PrintOne();
            // testclass2.Chap6_5.TestClass.MyMethod1();
            TestClass.MyMethod1()
        }
    }
}