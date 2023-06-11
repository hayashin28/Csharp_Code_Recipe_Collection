// See https://aka.ms/new-console-template for more information
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

        // 文字列の値設定
        worksheet.Cell("A1").Style.NumberFormat.Format = "@"
        worksheet.Cell("B1").Value = "Hello World";

        // 拡張子を付けて保存
        workbook.SaveAs(string.Concat(path, ".xlsx"));
    }

}
catch (exception e)
{
}

