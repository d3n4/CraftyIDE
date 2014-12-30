using System.ComponentModel;

namespace CraftyIDE.Core.Project
{
    public abstract class TProjectItem : IUpdateable, ISaveable
    {
        public abstract void Update();

        public abstract void Save();
    }
}
