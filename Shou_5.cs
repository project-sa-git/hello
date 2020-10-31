using System;

namespace Shou_5
{
    class Shou_5
    {
        // static void Main(string[] args)
        // {
        //     // Switch();
        //     // AryError();
        //     // ForEach();
        //     // Continue();
        //     // Toi_4();
        //     Jisaku();
            
        // }

        static void Toi_4()
        {
            var gstr = new[] {"明治", "大正", "昭和", "平成", "令和" }; //=>　新しい配列作成し、変数gstrに入れる
            // string[] ary = { "明治", "大正", "昭和", "平成", "令和"};

            // 配列のデータを１つずつ取得
            foreach ( string gengo in gstr )
            // foreach ( string gengo in ary )
            {
                Console.WriteLine( gengo );
            }
        }

        static void Jisaku()
        {
            var ary_doubutu = new[] { "さる", "とり", "いぬ"};

            foreach (var doubutu in ary_doubutu)
            {
                Console.WriteLine( doubutu );
            }
        }

        static void Toi_3()
        {
                                                                                // int x = 0;
                                                                                // for ( int i = 0; true; i++)
            for ( int i = 0; i <= 50; i++ ) //=> 真ん中の値は条件
            {
                                                                                //     if ( i % 3 == 0 || i % 10 )
                if ( (i % 3 == 0) || (i % 10 == 3) || (i / 10 == 3) )
                // Console.WriteLine(23 % 10);        // output: 3
                // Console.WriteLine(35 / 10 == 3);   // output: True
                {
                    Console.WriteLine( i ); //=> 条件を満たしていたら出力
                }
            }

        }

        static void Toi_2_1()
        {
            int i = 0;
            int x = 0;

            while ( i < 11)
            {
                x += i;
                i++;
            }
            Console.WriteLine( x );
        }
        static void Toi_2()
        {
            int x = 0;
            for ( int i = 0; true; i++)
            {
                if ( i <= 10 )
                {
                    x += i;
                }
                else
                {
                    break;
                }
            }
        }



        static void Continue()
        {
            for ( int i = 0 ; true ; i++)
            {
                Console.WriteLine( i );
                if ( i < 8 )
                {
                    continue; // カウンタ変数を更新してループ先頭に戻る
                }
                else if ( i == 10 )
                {
                    break;
                }
                Console.WriteLine( i );
            }
        }
            // 出力結果
            // 1 
            // 2 
            // 3 
            // 4 
            // 5 
            // 6 
            // 7 
            // 8 
            // 8 
            // 9 
            // 9 
            // 10

        static void ForEach()
        {
            string[] j = { "あか", "あお", "しろ", "緑"};

            // 配列のデータを１つずつ取得
            foreach ( string str in j )
            {
                Console.WriteLine( str );
            }
                // Console.WriteLine( str ); 　→　実行エラー：スコープ外
        }

        static void AryError()
        {
            string[] j = { "グー", "チョキ", "パー" };

            // 「i < 5」は配列の範囲を超えるので実行でエラー
            for ( int i = 0; i < 3; i++)
            {
                Console.WriteLine( j[i] );
            }
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
