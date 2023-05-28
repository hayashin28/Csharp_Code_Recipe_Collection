using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information
/*
using Recipe_343;

var xls = MyExcelBook.Create("example.xlsx");
xls.CreateSheet("mySheet");
for (int i = 0; i < 3; i++)
{
    var row  = xls.CreateRow(i);
    for (int col = 0; col < 5; col++)
    {
        var val = $"{row.RowNum}-{col}";
        xls.SetValue(row, col, val);
    }
}
xls.Save();
*/
using ClosedXML.Excel;

var path = "example.xlsx";

// ブックを生成
using (var workbook = new XLWorkbook())
{
    // シートを生成
    var worksheet = workbook.Worksheets.Add("mySheet");

    for (int i = 1; i <= 3; i++)
    {
        for (int j = 1; j <= 5; j++)
        {
            // セルに値を代入(いろんな指定ができます)
            worksheet.Cell(i, j).Value = $"{i} - {j}";
        }
    }
    // 保存
    workbook.SaveAs(path);
}
Console.WriteLine("Excelファイルを保存しました。");
