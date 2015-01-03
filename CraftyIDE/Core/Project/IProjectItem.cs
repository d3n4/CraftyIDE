using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftyIDE.Core.Project
{
    public interface IProjectItem : ISaveable, IUpdateable
    {
        string Identifier { get; set; }
        bool Included { get; set; }
        bool Hidden { get; set; }
    }
}
