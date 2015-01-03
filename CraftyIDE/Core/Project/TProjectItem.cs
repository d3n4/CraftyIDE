using System.ComponentModel;

namespace CraftyIDE.Core.Project
{
    public abstract class TProjectItem : IProjectItem
    {
        [DefaultValue(true)]
        [ReadOnly(true)]
        public bool Included { get; set; }
        [ReadOnly(true)]
        [DefaultValue(false)]
        public bool Hidden { get; set; }

        [ReadOnly(true)]
        public abstract string Identifier { get; set; }

        public abstract void Update();

        public abstract void Save();
    }
}
