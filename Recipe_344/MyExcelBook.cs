using System;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Recipe_344
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

        public void CreateSheet(string name) =>
            _sheet = _xssFWorkbook.CreateSheet(name);

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

        // 以降が新たに追加したメソッド
        public static MyExcelBook Open(string filePath)
        {
            var obj = new MyExcelBook();
            obj._filepath = filePath;
            using var stream = new FileStream(filePath, FileMode.Open);
            obj._xssFWorkbook = new XSSFWorkbook(stream);
            return obj;
        }

        public void SelectSheet(int no) =>
            _sheet = _xssFWorkbook.GetSheetAt(no);

        public object GetValue(int row, int col)
        {
            var rowobj = _sheet.GetRow(row);
            var cell = rowobj.GetCell(col);
            return cell == null ? null : _CellValue(cell, cell.CellType);
        }

        private object _CellValue(ICell cell, CellType type = CellType.Unknown)
        {
            var atype = type == CellType.Unknown ? cell.CellType : type;
            switch (atype)
            {
                case CellType.String:
                    return cell.StringCellValue;
                case CellType.Boolean:
                    return cell.BooleanCellValue;
                case CellType.Numeric:
                    // 日付の場合も、Numeric型になる。
                    // IsCellDateFormattedメソッドで区別している。
                    //ただし日付でもFalseが返るパターンもある。これはサポート外
                    if (DateUtil.IsCellDateFormatted(cell))
                        return cell.DateCellValue;
                    else
                        return cell.NumericCellValue;
                case CellType.Formula:
                    // セルが式の場合は、_CellValueを再帰呼び出ししている
                    var cellFormula = cell.CellFormula;
                    return _CellValue(cell, cell.CachedFormulaResultType);
                case CellType.Blank:
                    return "";
                default:
                    return null;
            }
        }
    }
}