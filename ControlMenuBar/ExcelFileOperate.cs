using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelLib = Microsoft.Office.Interop.Excel;
namespace ControlMenuBar
{
   public  class ExcelFileOperate
    {
        public static DataSet GetDataSetFromExcel(string strFileName)         //strFileName指定的路径+文件名.xls
        {
            if (strFileName != "")
            {
                //string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strFileName + ";Extended Properties=Excel 8.0";
                string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFileName + ";Extended Properties='Excel 12.0; HDR=yes; IMEX=0'";
                string sql = "select * from [Sheet1$]";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                }
                catch (Exception ex)
                {
                    return null;
                }
                return ds;
            }
            else
            {
                return null;
            }
        }
       public  static bool SaveDataTableToXls(System.Data.DataTable dt, string xlsPath)
        {
            ExcelLib.Application Excel_App = null;
            Excel_App = new ExcelLib.Application();
            Excel_App.Visible = false;
            Excel_App.DisplayAlerts = false;

            if (File.Exists(xlsPath))
            {
                File.Delete(xlsPath);
            }

            var wb = Excel_App.Application.Workbooks.Add(true);
            var sh = wb.ActiveSheet;

            int currentRow = 1;
            int startCol = 1;
            int colCount = dt.Columns.Count;
            int rowCount = dt.Rows.Count;

            // write title
            for (int i = 0; i < colCount; i++)
            {
                sh.Cells[currentRow, startCol + i]
                    = dt.Columns[i].Caption;
            }

            // write data   可能因数据量大而耗时长，后期可写进度条
            for (int i = 0; i < rowCount; i++)
            {
                var row = dt.Rows[i];
                currentRow++;
                for (int ii = 0; ii < colCount; ii++)
                {
                    sh.Cells[currentRow, startCol + ii] = row[ii];
                }
            }

            // save excel
            wb.Close(true, xlsPath);
            return true;
        }
    }
}
