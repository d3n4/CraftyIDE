using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CraftyIDE.Core
{
    public class DateSorter : System.Collections.IComparer
    {
        public int Compare(object a, object b)
        {
            var fa = new FileInfo(((TreeNode) a).Name + "/properties.json");
            var fb = new FileInfo(((TreeNode)b).Name + "/properties.json");
            if (fa.Exists && fb.Exists)
                return fa.LastWriteTime.Ticks > fb.LastWriteTime.Ticks ? -1 : 1;
            return -1;
        }
    }

}
