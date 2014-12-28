using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RubberGameIDE
{
    public class TestObject
    {
        [Category("Additional")]
        [Description("motd text goes here")]
        public string Motd { get; set; }

        [Category("Player")]
        [Description("health param")]
        public int health { get; set; }


    }
}
