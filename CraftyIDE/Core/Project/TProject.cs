using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public string DirectoryPath { get; set; }

        [Category("Canvas")]
        [Description("Canvas width")]
        public int Width { get; set; }

        [Category("Canvas")]
        [Description("Canvas height")]
        public int Height { get; set; }

        public TModule ProjectModule;


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

        /*
        [Category("Project")]
        [Description("Project modules")]
        [Editor(typeof(UITypeEditor), typeof(UITypeEditor))]
        public TProjectItemList<TModule> Modules { get; set; }

        [Category("Project")]
        [Description("Project components")]
        [Editor(typeof(UITypeEditor), typeof(UITypeEditor))]
        public TProjectItemList<TComponent> Components { get; set; }
        */
        /*[Category("Project")]
        [Description("Project components raw list")]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string ComponentsList { get; set; }*/


        public Dictionary<string, bool> ProjectTreeState;

        public TProject()
        {
            //Modules = new TProjectItemList<TModule>();
            //Components = new TProjectItemList<TComponent>();
            //Components.Add(new TComponent("2D", "Components/2D.js"));
        }

        public override void Update()
        {
            ProjectModule.Update();
        }

        public override void Save()
        {
            ProjectModule.Save();
            File.WriteAllText(DirectoryPath + "/properties.json", JSON.Beautify(JSON.ToJSON(this)));
        }

        public static TProject Open(string projectName)
        {
            var projectDirectory = "Projects/" + projectName;
            if (!Directory.Exists(projectDirectory))
                return null;

            var propertiesFile = projectDirectory + "/properties.json";
            var project = JSON.ToObject<TProject>(File.ReadAllText(propertiesFile));

            return project;
        }

        public static TProjectResult Create(string projectName, string template = "Project")
        {
            projectName = projectName.Trim();
            var projectTemplate = template;
            var projectDirectory = new DirectoryInfo("Projects/" + projectName);
            if(projectName.Length == 0 || projectName.Contains("/") || projectName.Contains("\\") || projectName.Contains("*") || projectName.Contains("."))
                return TProjectResult.InvalidName;
            if (projectDirectory.Exists)
                return TProjectResult.Exists;
            Utils.DirectoryCopy(projectTemplate, projectDirectory.FullName);
            var project = new TProject
            {
                Name = projectDirectory.Name,
                DirectoryPath = projectDirectory.FullName,
                Width = 800,
                Height = 600,
                ProjectModule = new TModule(projectDirectory.Name, projectDirectory.FullName) { Included = true }
            };

            project.ProjectModule.Modules.Add(TModule.LoadFrom("Library/Modules/CraftyJS"));
            project.ProjectModule.Modules.Add(TModule.LoadFrom("Library/Modules/MySuperLib"));

            project.Save();
            //File.WriteAllText(projectDirectory.FullName + "/properties.json", JSON.Beautify(JSON.ToJSON(project)));

            return TProjectResult.Success;
        }
    }
}
