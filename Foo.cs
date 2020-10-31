using System;

namespace Foospace
{
    class Prog
    {
        // static void Main(string[] args)
        // {
        //     Foo();
        //     Bar();
        //     Anonymous();
        // }

        static void Foo()
        {
            Console.WriteLine("Foooooooooooooo!!!!");
        }

        static void Bar()
        {
            Console.WriteLine("baaaarrrrrrrr");
        }

        static void Anonymous()
        {
            var x = new { Name = "匿名", Age = 18 };
            Console.WriteLine ( x.Name );
        }

    }
}
