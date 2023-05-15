// See https://aka.ms/new-console-template for more information
using Recipe_344;

var xls = MyExcelBook.Open("example.xlsx");
xls.SelectSheet(0);
for (int i = 0; i < 5; i++)
{
	var val = xls.GetValue(2, i);
	Console.WriteLine(val.ToString());
}