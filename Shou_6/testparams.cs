using System;
class TestClass
{
    // int型の可変パラメータ設定params
    public int SumAll(params int[] numary)
    {
        int sum = 0;

        foreach(int n in numary)
        {
            sum += n;
        }
        return sum;
    }
}

class MainClass
{
    static void Main()
    {
        TestClass test = new TestClass();
        Console.WriteLine(test.SumAll(1, 2,3));// 出力結果： 6
        Console.WriteLine(test.SumAll());// 出力結果： 0
    }
}