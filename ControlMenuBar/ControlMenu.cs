using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMenuBar
{
    class ControlMenu: IMenuDef
    {
        #region
        public string Caption
        {
            get { return "管理措施"; }
        }

        public void GetItemInfo(int pos, ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "ControlMenuBar.ColumnCmd";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "ControlMenuBar.LineChartCmd";
                    itemDef.Group = false;
                    break;
                default:
                    break;
            }
        }

        public long ItemCount
        {
            get { return 2; }
        }

        public string Name
        {
            get { return "ControlMneu"; }
        }
        #endregion
    }
}
