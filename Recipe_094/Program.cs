// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

var mul2 = new HashSet<int>(){ 2, 4, 6, 8, 10, 12 };
var mul3 = new HashSet<int>(){ 3, 6, 9, 12, 15, 18 };

// 和集合 少なくとも何れか一方の集合に属する要素を集めた集合
var set = new HashSet<int>(mul2);
set.UnionWith(mul3);
Console.WriteLine(string.Join(' ', set));

// 差集合 ある集合から別の集合に含まれている要素を取り除いた集合
set = new HashSet<int>(mul2);
set.ExceptWith(mul3);
Console.WriteLine(string.Join(' ', set));

// 積集合 ふたつの集合の両方に含まれている要素を集めた集合
set = new HashSet<int>(mul2);
set.IntersectWith(mul3);
Console.WriteLine(string.Join(' ', set));
