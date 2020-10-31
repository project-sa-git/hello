using System;

namespace Shou_5
{
    class Shou_5
    {
        static void Main(string[] args)
        {
            // Switch();
            
        }

        static void Switch()
        {
            // int month = DateTime.Now.Month; //現在の月を取得    
            int month = 2; //現在の月を取得    

            switch ( month )
            {
                case 1 :
                    Console.WriteLine( "睦月" );
                    break;
                case 2 :
                    Console.WriteLine( "如月" );
                    break;
                case 3 :
                    Console.WriteLine( "弥生" );
                    break;
                case 7 :
                case 8 :    // => 7, 8は同じ処理（省略）
                    Console.WriteLine( "夏休み" );
                    break;
                default :
                    Console.WriteLine( month + "月" );
                    break;
            }
        }

    }
}
