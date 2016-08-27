using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ControlMenuBar
{
    public partial class LineChart : Form
    {
        private DataTable _dt;      //数据源
        private string _xFieldName; //x轴对应的数据源字段名
        private string _yFieldName1; //y轴对应的数据源字段名
        private string _legendText1; //图例文本
        private string _yFieldName2; //y轴对应的数据源字段名
        private string _legendText2; //图例文本
        private string _yFieldName3; //y轴对应的数据源字段名
        private string _legendText3; //图例文本
        private string _yFieldName4; //y轴对应的数据源字段名
        private string _legendText4; //图例文本

        public LineChart(DataTable dt, string xFieldName, string yFieldName1, string yFieldaName2, string legendText1, string legendText2 ,string yFieldName3, string yFieldaName4, string legendText3, string legendText4)
        {
            InitializeComponent();
            this._dt = dt;
            this._legendText1 = legendText1;
            this._legendText2 = legendText2;
            this._legendText3 = legendText3;
            this._legendText4 = legendText4;
            this._xFieldName = xFieldName;
            this._yFieldName1 = yFieldName1;
            this._yFieldName2 = yFieldaName2;
            this._yFieldName3 = yFieldName3;
            this._yFieldName4 = yFieldaName4;
        }

          private void LineChart_Load(object sender, EventArgs e)
        {
            try
            {
                chart1.DataSource = this._dt;
                chart1.DataBind();
                chart1.Series[0].ChartType = SeriesChartType.Column;
                chart1.Series[0].LegendText = this._legendText1;
                chart1.Series[0].XValueMember = this._xFieldName;//绑定的文字信息（名称）(坐标横轴)
                chart1.Series[0].YValueMembers = this._yFieldName1;// 绑定的值（数据）(坐标纵轴)
                //chart1.DataSource = this._dt;
                //chart1.DataBind();
                chart1.Series[1].ChartType = SeriesChartType.Column;
                chart1.Series[1].LegendText = this._legendText2;
                chart1.Series[1].XValueMember = this._xFieldName;//绑定的文字信息（名称）(坐标横轴)
                chart1.Series[1].YValueMembers = this._yFieldName2;// 绑定的值（数据）(坐标纵轴)
                //chart1.DataSource = this._dt;
                //chart1.DataBind();
                chart1.Series[2].ChartType = SeriesChartType.Column;
                chart1.Series[2].LegendText = this._legendText3;
                chart1.Series[2].XValueMember = this._xFieldName;//绑定的文字信息（名称）(坐标横轴)
                chart1.Series[2].YValueMembers = this._yFieldName3;// 绑定的值（数据）(坐标纵轴)
                //chart1.DataSource = this._dt;
                //chart1.DataBind();
                chart1.Series[3].ChartType = SeriesChartType.Column;
                chart1.Series[3].LegendText = this._legendText4;
                chart1.Series[3].XValueMember = this._xFieldName;//绑定的文字信息（名称）(坐标横轴)
                chart1.Series[3].YValueMembers = this._yFieldName4;// 绑定的值（数据）(坐标纵轴)
            }
            catch (System.Exception ex)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//导出图片
        {
            //保存Chart控件的图片
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG文件|*.jpg|PNG文件|*.png|BMP文件|*.bmp";
            sfd.Title = "导出统计图";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FilterIndex == 1)
                    chart1.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
                else if (sfd.FilterIndex == 2)
                    chart1.SaveImage(sfd.FileName, ChartImageFormat.Png);
                else
                    chart1.SaveImage(sfd.FileName, ChartImageFormat.Bmp);
            } 
        }

     
    }
}
