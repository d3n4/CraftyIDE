using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftyIDE.Core.Project
{
    public class TProjectItemList<T> : List<T>, ISaveable, IUpdateable where T : TProjectItem
    {
        public void Save()
        {
            foreach (var item in this)
                item.Save();
        }
        public void Update()
        {
            foreach (var item in this)
                item.Update();
        }
    }
}
