// See https://aka.ms/new-console-template for more information
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