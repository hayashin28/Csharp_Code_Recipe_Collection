// See https://aka.ms/new-console-template for more information
/*
using Recipe_342;

var xls = MyExcelBook.Create("example.xlsx");
xls.CreateSheet("mySheet");
xls.Save();
*/
using ClosedXML.Excel;

var path = "example.xlsx";
// ブックを生成
using (var workbook = new XLWorkbook())
{
    // シートを生成
    var worksheet = workbook.Worksheets.Add("mySheet");
    // 保存
    workbook.SaveAs(path);
}




