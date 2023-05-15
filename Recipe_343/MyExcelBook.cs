using System;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Recipe_343
{
    public sealed class MyExcelBook
    {
        private XSSFWorkbook? _xssFWorkbook;
        private ISheet? _sheet;
        private string _filepath;

        private MyExcelBook()
        {
            _xssFWorkbook = new XSSFWorkbook();
        }

        public static MyExcelBook Create(string filepath)
        {
            var obj = new MyExcelBook();
            obj._filepath = filepath;
            obj._xssFWorkbook = new XSSFWorkbook();
            return obj; 
        }

        public void CreateSheet(string name) => _sheet = _xssFWorkbook.CreateSheet(name);
        public IRow CreateRow(int no) => _sheet.CreateRow(no);

        public void SetValue(IRow row, int col, string value)
        {
            ICell cell = row.CreateCell(col);
            cell.SetCellValue(value); 
        }
        
        public void Save()
        {
            using var stream = new FileStream(_filepath, FileMode.Create);
            _xssFWorkbook.Write(stream);
        }
    }
}