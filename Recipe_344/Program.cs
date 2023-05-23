// See https://aka.ms/new-console-template for more information
/*
using Recipe_344;

var xls = MyExcelBook.Open("example.xlsx");
xls.SelectSheet(0);
for (int i = 0; i < 5; i++)
{
	var val = xls.GetValue(2, i);
	Console.WriteLine(val.ToString());
}
*/
using ClosedXML.Excel;

var path = "example.xlsx";

// ブックを読み込む
var workbook = new XLWorkbook(path);
// 1シート目を取得
var worksheet = workbook.Worksheets.Worksheet(1);
for (int i = 1; i <= 5; i++)
{
	var val = worksheet.Cell(2, i).Value;
	Console.WriteLine(val.ToString());
}	
