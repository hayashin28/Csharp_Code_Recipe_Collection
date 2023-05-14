// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

var queue = new Queue<int>();

// 値をキューの末尾に追加
queue.Enqueue(4);
queue.Enqueue(8);
queue.Enqueue(3);
queue.Enqueue(9);

while (queue.Count > 0)
{
    // キューの先頭の要素を取り出して削除する。
    var n = queue.Dequeue();
    Console.WriteLine(n);
}

// キューに溜まっている要素数を取得
Console.WriteLine($"Count: {queue.Count}");
