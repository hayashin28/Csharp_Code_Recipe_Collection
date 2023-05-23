// See https://aka.ms/new-console-template for more information
/*
using Recipe_345;

var xls = MyExcelBook.Open("example.xlsx");
xls.SelectSheet(0);
foreach (var row in xls.GetRows())
{
	var line = new List<string>();
	foreach (var cell in xls.GetCells(row))
	{
		line.Add(cell?.ToString());
	}
	Console.WriteLine(String.Join("\t", line));
}
*/
using ClosedXML.Excel;

var path = "example.xlsx";
// ブックを読み込む
var workbook = new XLWorkbook(path);

// 1シート目を取得
var worksheet = workbook.Worksheets.Worksheet(1);

//値が入力されている範囲をテーブル形式で取得
var tbl = worksheet.RangeUsed().AsTable();

//取得結果を行単位でループ
foreach(var row in tbl.Rows())
{
	var line = new List<string>();
    
	//列単位でループ
    foreach(var cell in row.Cells())
    {
		line.Add(cell.Value.ToString());
    }
	Console.WriteLine(String.Join("\t", line));
}