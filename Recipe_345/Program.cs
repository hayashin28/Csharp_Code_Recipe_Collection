// See https://aka.ms/new-console-template for more information
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