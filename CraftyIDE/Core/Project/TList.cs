using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CraftyIDE.Core.Project
{
    public class TList<T> : List<T>, IProjectItem where T : IProjectItem
    {
        [ReadOnly(true)]
        public bool Included { get; set; }
        [ReadOnly(true)]
        public bool Hidden { get; set; }

        [ReadOnly(true)]
        public string Identifier
        {
            get
            {
                return GetHashCode().ToString();
            }
            set { }
        }

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
