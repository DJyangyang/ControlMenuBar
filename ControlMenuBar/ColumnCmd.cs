using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMenuBar
{
    class ColumnCmd :ICommand
    {
        private MyPluginEngine.IApplication hk;
        private Bitmap m_hBitmap;
        private ICommand cmd = null;
        ColumnTable pColumnChart;
        public ColumnCmd()
        {
            string str = @"..\Data\Image\ControlMenuBar\4.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;
        }
        public System.Drawing.Bitmap Bitmap
        {
            get {return m_hBitmap; }
        }

        public string Caption
        {
            get { return "协会成立的必要性"; }
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
            get { return ""; }
        }

        public string Message
        {
            get { return "协会成立的必要性"; }
        }

        public string Name
        {
            get { return "ColumnCmd"; }
        }

        public void OnClick()
        {
            ColumnTable columnChart = new ColumnTable();
            columnChart.ShowDialog();
        }

        public void OnCreate(IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                pColumnChart = new ColumnTable();
                pColumnChart.Visible = false;
            }
        }

        public string Tooltip
        {
            get { return "协会成立的必要性"; }
        }
    }
}
