// See https://aka.ms/new-console-template for more information
/*
using Recipe_342;

var xls = MyExcelBook.Create("example.xlsx");
xls.CreateSheet("mySheet");
xls.Save();
*/
using System;
using System.IO;
using ClosedXML.Excel;

Console.WriteLine("ファイル名を入力して下さい。");
try
{
    // キーボード入力を受け取る
    string path = Console.ReadLine();
    // ブックを生成
    using (var workbook = new XLWorkbook())
    {
        // シートを生成
        var worksheet = workbook.Worksheets.Add("mySheet");

        // 拡張子を付けて保存
        workbook.SaveAs(string.Concat(path, ".xlsx"));
    }
} 
catch(Exception e)
{
    // エラー内容を出力
	Console.WriteLine(e.Message);
}
