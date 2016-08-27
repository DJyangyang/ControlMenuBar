using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlMenuBar
{
    public partial class LineTable : Form
    {
        #region 私有变量
        private string _mdbFileFullName;  //mdb文件完整路径名
        private DBOperate _dbOperate; //数据库操作类
        #endregion
        public LineTable()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }

        private void btnBrowser2_Click(object sender, EventArgs e)//浏览
        {
            OpenFileDialog openDialog = new OpenFileDialog();//打开data文件夹下的mdb文件
            openDialog.InitialDirectory = Application.StartupPath + @"\data";
            openDialog.Filter = "mdb文件|*.mdb";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _mdbFileFullName = openDialog.FileName;
               //读取数据库的表名，并默认加载第一个表
                _dbOperate = new DBOperate(_mdbFileFullName, "");
                List<string> tableNames = _dbOperate.GetTableNameList();
                cmbxTableNames1.DataSource = tableNames;
                cmbxTableNames1.SelectedIndex = 0;
            }
           }

        private void cmbxTableNames1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbxTableNames1_TextChanged(object sender, EventArgs e)//重新加载表数据后，同步更新自变量、因变量字段值
        {
            if (cmbxTableNames1.DataSource == null || _dbOperate == null)
            {
                return;
            }
            DataTable dt = _dbOperate.GetDataTableByName(cmbxTableNames1.Text);
            dataGridView2.DataSource = dt;

            //重新加载表数据后，同步更新自变量、因变量字段值
            cmbxXField1.Items.Clear();
            cmbxYField1.Items.Clear();
            cmbxYField2.Items.Clear();
            cmbxYField3.Items.Clear();
            cmbxYField4.Items.Clear();
            foreach (DataColumn dc in dt.Columns)
            {
                string fieldName = dc.ColumnName;
                cmbxXField1.Items.Add(fieldName);
                cmbxYField1.Items.Add(fieldName);
                cmbxYField2.Items.Add(fieldName);
                cmbxYField3.Items.Add(fieldName);
                cmbxYField4.Items.Add(fieldName);
            }
            cmbxXField1.SelectedIndex = 0;
            cmbxYField1.SelectedIndex = 0;
            cmbxYField2.SelectedIndex = 0;
            cmbxYField3.SelectedIndex = 0;
            cmbxYField4.SelectedIndex = 0;
            //设置成图范围的行范围
            txbxStartRowNum1.Text = "1";
            txbxEndRowNum1.Text = "12";
        }
      
        private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
  #region     //更改值描述文本的默认值
        private void cmbxYField1_TextChanged(object sender, EventArgs e)
        {
            cmbxValueDescribe01.Text = cmbxYField1.Text;

        }

        private void cmbxYField2_TextChanged(object sender, EventArgs e)
        {
            cmbxValueDescribe02.Text = cmbxYField2.Text;
        }

        private void cmbxYField3_TextChanged(object sender, EventArgs e)
        {
            cmbxValueDescribe03.Text = cmbxYField3.Text;
        }

        private void cmbxYField4_TextChanged(object sender, EventArgs e)
        {
            cmbxValueDescribe04.Text = cmbxYField4.Text;
        }
        #endregion

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbxTableNames1.Text))
            {
                MessageBox.Show("未加载任何数据表！");
                return;
            }
            if (String.IsNullOrEmpty(cmbxXField1.Text) || String.IsNullOrEmpty(cmbxYField1.Text) || String.IsNullOrEmpty(cmbxYField2.Text) || String.IsNullOrEmpty(cmbxYField3.Text) || String.IsNullOrEmpty(cmbxYField4.Text))
            {
                MessageBox.Show("自变量和因变量不能为空");
                return;
            }

            //判断因变量字段是否是值字段，或者是否能强制转换成值
            DataTable sourceDt = dataGridView2.DataSource as DataTable;
            FieldValueType yFieldType1 = DataTableImp.GetFieldType(sourceDt, cmbxYField1.Text);
            FieldValueType yFieldType2 = DataTableImp.GetFieldType(sourceDt, cmbxYField2.Text);
            FieldValueType yFieldType3= DataTableImp.GetFieldType(sourceDt, cmbxYField3.Text);
            FieldValueType yFieldType4 = DataTableImp.GetFieldType(sourceDt, cmbxYField4.Text);
            if (yFieldType1 == FieldValueType.非值文本 || yFieldType2 == FieldValueType.非值文本 || yFieldType3 == FieldValueType.非值文本 || yFieldType4 == FieldValueType.非值文本)
            {
                MessageBox.Show("因变量字段不可为非数值字段！");
                return;
            }
            List<string> fieldNames1 = new List<string>() { cmbxXField1.Text, cmbxYField1.Text };
            List<string> fieldNames2= new List<string>() { cmbxXField1.Text, cmbxYField2.Text };
            List<string> fieldNames3 = new List<string>() { cmbxXField1.Text, cmbxYField3.Text };
            List<string> fieldNames4= new List<string>() { cmbxXField1.Text, cmbxYField4.Text };
            int startRowNum = Convert.ToInt32(txbxStartRowNum1.Text) - 1; //DataTable的行号从0开始
            int endRowNum = Convert.ToInt32(txbxEndRowNum1.Text) - 1;
            DataTable tempDt = DataTableImp.GetTableByFieldNamesAndRowNumRange2(sourceDt, fieldNames1, fieldNames2, fieldNames3, fieldNames4, startRowNum, endRowNum);
            //再进行因变量字段值的值类型转换
            DataTable resultDt = DataTableImp.ConvertFieldToType2(tempDt, cmbxYField1.Text, cmbxYField2.Text,cmbxYField3.Text, cmbxYField4.Text, yFieldType1, yFieldType2, yFieldType3, yFieldType4);
            LineChart linefrm = new LineChart(resultDt, cmbxXField1.Text, cmbxYField1.Text, cmbxYField2.Text,cmbxYField3.Text, cmbxYField4.Text, cmbxValueDescribe01.Text, cmbxValueDescribe02.Text, cmbxValueDescribe03.Text, cmbxValueDescribe04.Text);
            linefrm.ShowDialog();
        }


    }
}
