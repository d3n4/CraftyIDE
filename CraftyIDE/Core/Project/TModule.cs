using System.ComponentModel;

namespace CraftyIDE.Core.Project
{
    public class TModule : TProjectItem
    {
        [ReadOnly(true)]
        public string Name { get; set; }

        [ReadOnly(true)]
        public string Directory { get; set; }

        public TModule()
        {
        }

        public TModule(string name, string directory)
        {
            Name = name;
            Directory = directory;
        }

        public override void Update()
        {
            
        }

        public override void Save()
        {
            
        }
    }
}
