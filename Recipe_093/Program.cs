// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

// インスタンスの生成
var hashSet = new HashSet<string>();

// コレクションに値を追加する
hashSet.Add("apple");
hashSet.Add("banana");
hashSet.Add("grape");
hashSet.Add("lemon");

// 以下は追加に失敗する。※例外は出ない。
hashSet.Add("lemon");

// 要素数
Console.WriteLine(hashSet.Count);

// hashSetから削除する
hashSet.Remove("grape");

// hashSet内に含まれているか。
var contains = hashSet.Contains("grape");
Console.WriteLine(contains);

// 順に値を取り出す
foreach (var item in hashSet)
{
    Console.Write($"{item} ");
}
Console.WriteLine();