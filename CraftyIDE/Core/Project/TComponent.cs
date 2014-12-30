using System.ComponentModel;

namespace CraftyIDE.Core.Project
{
    public class TComponent : TProjectItem
    {
        [ReadOnly(true)]
        public string Name { get; set; }

        [ReadOnly(true)]
        public string File { get; set; }

        public TComponent()
        {
        }

        public TComponent(string name, string file)
        {
            Name = name;
            File = file;
        }

        public override void Update()
        {
            
        }

        public override void Save()
        {
            
        }
    }
}
