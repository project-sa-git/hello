using System;

namespace Shou_3
{
    class Shou_3
    {
        // static void Main(string[] args)
        // {
        //     Toi_2();
        //     Toi_3();
        //     Toi_4();
        // }

        static void Toi_2()
        {
            float f = 123F;
            float f_2 = 1.23F;

            Console.WriteLine( f );
            Console.WriteLine( f_2 );
        }

        static void Chikugo()
        {
            string s = @"改行も
            できます";
            Console.WriteLine ( s );
        }

        static void Toi_3()
        {
            // 逐語的リテラル文字列
            string s1 = @"\1,000
\20,000";
            Console.WriteLine( s1 );

            string s2 = "\\1,000\n\\20,000";
            Console.WriteLine( s2 );
        }

        enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        static void Toi_4()
        {
            var a = Season.Autumn;
            Console.WriteLine( Season.Spring );
            Console.WriteLine( a );
            Console.WriteLine((int)Season.Winter);

            var ary = new[] {"健太", "礼", "松井"}; //=> 数入れなければ自由型（個数）？
            Console.WriteLine(ary[(int)Season.Summer]);
        }
    }
}
