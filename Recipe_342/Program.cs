// See https://aka.ms/new-console-template for more information
using Recipe_342;

var xls = MyExcelBook.Create("example.xlsx");
xls.CreateSheet("MySheet");
xls.Save();
