﻿using System.ComponentModel;

namespace CraftyIDE.Core.Project
{
    public class TSound : TProjectItem
    {
        [ReadOnly(true)]
        public string Name { get; set; }

        [ReadOnly(true)]
        public string File { get; set; }
        
        public override string Identifier
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public TSound()
        {
        }

        public TSound(string name, string file)
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
