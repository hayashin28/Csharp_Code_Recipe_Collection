// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

var xls = MyExcelBook.Create("example.xlsx");
xls.CreateSheet("MySheet");
xls.Save();

public sealed class MyExcelBook
{
    private XSSFWorkbook? _xssFWorkbook;
    private ISheet? _sheet;

    private MyExcelBook()
    {
        _xssFWorkbook = new XSSFWorkbook();
    }

    private string _filepath;
    public static MyExcelBook Create(string filepath)
    {
        var obj = new MyExcelBook();
        obj._filepath = filepath;
        obj._xssFWorkbook = new XSSFWorkbook();
        return obj; 
    }

    public void CreateSheet(string name) => _sheet = _xssFWorkbook.CreateSheet(name);

    public void Save()
    {
        using var stream = new FileStream(_filepath, FileMode.Create);
        _xssFWorkbook.Write(stream);
    }
}