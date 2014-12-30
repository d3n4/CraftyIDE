using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing.Design;
using System.IO;
using System.Web.UI.Design.WebControls;
using fastJSON;

namespace CraftyIDE.Core.Project
{
    public class TProject : TProjectItem
    {
        [Category("Project")]
        [Description("Project name")]
        [ReadOnly(true)]
        public string Name { get; set; }

        [Category("Project")]
        [Description("Project directory")]
        [ReadOnly(true)]
        public string Directory { get; set; }

        [Category("Canvas")]
        [Description("Canvas width")]
        public int Width { get; set; }

        [Category("Canvas")]
        [Description("Canvas height")]
        public int Height { get; set; }

        [Category("Project")]
        [Description("Project modules")]
        [Editor(typeof(UITypeEditor), typeof(UITypeEditor))]
        public TProjectItemList<TModule> Modules { get; set; }

        [Category("Project")]
        [Description("Project components")]
        [Editor(typeof(UITypeEditor), typeof(UITypeEditor))]
        public TProjectItemList<TComponent> Components { get; set; }

        public Dictionary<string, bool> ProjectTreeState;

        public TProject()
        {
            Modules = new TProjectItemList<TModule>();
            Components = new TProjectItemList<TComponent>();
            Components.Add(new TComponent("2D", "Components/2D.js"));
        }

        public override void Update()
        {
            Modules.Update();
            Components.Update();
        }

        public override void Save()
        {
            File.WriteAllText(Directory + "/properties.json", JSON.Beautify(JSON.ToJSON(this)));
            Modules.Save();
            Components.Save();
        }

        public static TProject Open(string projectName)
        {
            var projectDirectory = Environment.CurrentDirectory + "/Projects/" + projectName;
            if (!System.IO.Directory.Exists(projectDirectory))
                return null;

            var propertiesFile = projectDirectory + "/properties.json";
            var project = JSON.ToObject<TProject>(File.ReadAllText(propertiesFile));

            return project;
        }

        public static TProjectResult Create(string projectName, string template = "Project")
        {
            projectName = projectName.Trim();
            var projectTemplate = Environment.CurrentDirectory + "/" + template;
            var projectDirectory = new DirectoryInfo(Environment.CurrentDirectory + "/Projects/" + projectName);
            if(projectName.Length == 0 || projectName.Contains("/") || projectName.Contains("\\") || projectName.Contains("*") || projectName.Contains("."))
                return TProjectResult.InvalidName;
            if (projectDirectory.Exists)
                return TProjectResult.Exists;
            Utils.DirectoryCopy(projectTemplate, projectDirectory.FullName);
            var project = new TProject
            {
                Name = projectDirectory.Name,
                Directory = projectDirectory.FullName,
                Width = 800,
                Height = 600
            };

            File.WriteAllText(projectDirectory.FullName + "/properties.json", JSON.Beautify(JSON.ToJSON(project)));

            return TProjectResult.Success;
        }
    }
}
