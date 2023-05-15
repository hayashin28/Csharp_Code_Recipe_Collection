// See https://aka.ms/new-console-template for more information
using System;

// null許容型変数を利用する
int? num = null;
// nullかどうかを判断する != nullでも良い
if (num.HasValue) 
{
    int val = num.Value;    // Valueプロパティで、値を取得する
    Console.WriteLine(val);
}
int num2 = num ?? -1;       // null合体演算子も利用できる
Console.WriteLine(num2);

int? num3 = 36;
if (num3 is int myValue)   // is演算子による検査
{
    Console.WriteLine(myValue);
}
else
{
    Console.WriteLine("num3は値を持っていない");
}
