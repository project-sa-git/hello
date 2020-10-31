using System;

namespace Shou_4
{
    class Shou_4
    {
        // static void Main(string[] args)
        // {
        //     Toi_2();
        //     // Ren_4_3();
        //     // Ren_4_2();
        //     // Ren_4_1();
        // }

        static void Toi_2()
        {
            int x = 5;
            int y = 3;
            Console.WriteLine( Math.Pow( x + y, 2) );

            if ( x % 2 == 1 )
            {
                Console.WriteLine( "{0}は奇数です", x );
            }
            else
            {
                Console.WriteLine( "{0}は偶数です", x );
            }

            Console.WriteLine( Math.Pow( x + y, 2) );
        }

        static void Ren_4_3() //=> シフト演算子
        {
            int a = 162; //=> 0xA2(16進数）
            Console.WriteLine( Convert.ToString( a, 2)); //=> 10100010
            Console.WriteLine( Convert.ToString( a << 3, 2)); //=> 10100010000
            Console.WriteLine( Convert.ToString( a >> 3, 2)); //=> 10100

        }

        static void Ren_4_2()
        {
            int a = 0b0000_0010; //=> 2進数表記。実質「2」
            int b = 0b0000_1111; //=> 2進数表記。実質「15」
            long c = 0b0000_11111111111111111111111111111101; //=> intでは大きすぎてエラー

            Console.WriteLine( Convert.ToString( a & b, 10) ); //=> 2(10進数)
            Console.WriteLine( Convert.ToString( a | b, 16 )); //=> f(16進数)
            Console.WriteLine( Convert.ToString( a ^ b, 2 )); //=> 1101(2進数。実質「13」)
            Console.WriteLine( Convert.ToString( ~a, 2 )); //=> 補助演算子。11111111111111111111111111111101(2進数。実質「4294967293」)
            Console.WriteLine( Convert.ToString( c, 10 )); //=> 2進数。実質「4294967293」)
        }

        static void Ren_4_1()
        {
            int x = 10;
            int y = 5;
            bool b = ( x != y );
            Console.WriteLine( b );
        }
    
    }
}
