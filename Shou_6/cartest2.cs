using System;

namespace Class_2
{
    class Car
    {
        // フィールド
        public string name;
        public int seats = 4;
        public string syasyu;

    }

    class MainClass
    {
        static void Mained()
            {
                // Test_2(); 1はなし
                // Test_3();
                Test_4();
                
            }

        static void Test_4()
        {
            Car mycar1 = new Car();
            Car mycar2 = new Car();
            Car mycar3 = mycar2; //インスタンスの代入

            mycar3.name = "サブ化ー";
            Console.WriteLine(mycar3.name);// 出力結果： サブ化ー
            Console.WriteLine(mycar2.name);// 出力結果： サブ化ー
            Console.WriteLine(mycar2==mycar3);// 出力結果： True
        }

        

        static void Test_3()
        {
            Car mycar1 = new Car();
            Car mycar2 = new Car();

            // インスタンスを比較する
            Console.WriteLine(mycar1 == mycar2); //=> False

            mycar1.syasyu = "ミニバン";
            Console.WriteLine(mycar1); // 出力結果： Class_2.Car
            Console.WriteLine(mycar1.syasyu); // 出力結果： ミニバン
        }







        static void Test_2()
        {
            Car mycar = new Car();
            mycar.name = "maiカー"; //=> コメントアウトした場合null

            Console.WriteLine( mycar.name );
            Console.WriteLine( mycar.seats );
        }
    }
}

