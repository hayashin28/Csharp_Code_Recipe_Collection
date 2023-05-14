// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

var stack = new Stack<int>();

// stackに値をPush（先頭に挿入）する。
stack.Push(10);
stack.Push(20);
stack.Push(30);

// stackの値を参照（先頭の要素を参照。stackの内容に変更はない）
var peekValue = stack.Peek();
Console.WriteLine(peekValue);

// stackの要素巣を取得
Console.WriteLine(stack.Count);

while (stack.Count > 0)
{
    // stackから値をPop（先頭の要素を取り出して削除）
    var n = stack.Pop();
    Console.WriteLine(n);
}
