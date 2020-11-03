using System;

namespace Class_1
{
    class Car
    {
        // フィールド
        public string name;
        public int seats = 4;
    }

    class MainClass
    {
        static void Test_1()
        {
            Car mycar = new Car();
            mycar.name = "マイカー"; //=> コメントアウトした場合null

            Console.WriteLine( mycar.name );
            Console.WriteLine( mycar.seats );
        }
    }
}

