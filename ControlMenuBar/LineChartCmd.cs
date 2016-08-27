using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMenuBar
{
    class LineChartCmd :ICommand
    {
        private MyPluginEngine.IApplication hk;
        private Bitmap m_hBitmap;
        private ICommand cmd = null;
        LineTable linetab;
        public LineChartCmd()
        {
            string str = @"..\Data\Image\ControlMenuBar\3.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;
        }
        public System.Drawing.Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "管理措施"; }
        }

        public string Category
        {
            get { return "ControlMenu"; }
        }

        public bool Checked
        {
            get { return false; }
        }

        public bool Enabled
        {
            get { return true; }
        }

        public int HelpContextId
        {
            get { return 0; }
        }

        public string HelpFile
        {
            get {return ""; }
        }

        public string Message
        {
            get { return"管理措施"; }
        }

        public string Name
        {
            get { return "LineChartCmd"; }
        }

        public void OnClick()
        {
            LineTable linTab = new LineTable();
            linTab.ShowDialog();
        }

        public void OnCreate(IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                linetab = new LineTable();
                linetab.Visible = false;
            }
        }

        public string Tooltip
        {
            get { return "柱状图1"; }
        }
    }
}
