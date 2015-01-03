using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using fastJSON;

namespace CraftyIDE.Core.Project
{
    public class TModule : TProjectItem
    {
        [ReadOnly(true)]
        public string Name { get; set; }

        [ReadOnly(true)]
        public string DirectoryPath { get; set; }

        public bool DebugOnly { get; set; }
        public bool ReleaseOnly { get; set; }

        public bool AutoScan = false;


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

        public TList<TComponent> Components { get; set; }
        public TList<TModule> Modules { get; set; }
        public TList<TScene> Scenes { get; set; }
        public TList<TScript> Scripts { get; set; }
        public TList<TSound> Sounds { get; set; }
        public TList<TSprite> Sprites { get; set; }

        public static TModule LoadFrom(string moduleDirectory)
        {
            var module = JSON.ToObject<TModule>(File.ReadAllText(moduleDirectory + "/module.json"));
            module.DirectoryPath = moduleDirectory;
            module.Initialize();
            return module;
        }

        public TModule()
        {
        }

        public TModule(string name, string directoryPath)
        {
            Name = name;
            DirectoryPath = directoryPath;
            Components = new TList<TComponent>();
            Modules = new TList<TModule>();
            Scenes = new TList<TScene>();
            Scripts = new TList<TScript>();
            Sounds = new TList<TSound>();
            Sprites = new TList<TSprite>();
            DebugOnly = false;
            ReleaseOnly = true;
        }

        public TList<TComponent> GetComponents()
        {
            var list = new TList<TComponent>();

            list.AddRange(Components);

            if (Modules == null || Modules.Count <= 0) return list;

            foreach (var module in Modules)
                if (module.Included)
                    list.AddRange(module.GetComponents());

            return list;
        }

        public TList<TSprite> GetSprites()
        {
            var list = new TList<TSprite>();

            if (Sprites == null) return list;

            list.AddRange(Sprites);

            if (Modules == null || Modules.Count <= 0) return list;

            foreach (var module in Modules)
                if (module.Included)
                    list.AddRange(module.GetSprites());

            return list;
        }

        public TList<TScript> GetScripts()
        {
            var list = new TList<TScript>();

            list.AddRange(Scripts);

            if (Modules == null || Modules.Count <= 0) return list;

            foreach (var module in Modules)
                if (module.Included)
                    list.AddRange(module.GetScripts());

            return list;
        } 

        public TList<TModule> GetModules()
        {
            var list = new TList<TModule>();

            if (Modules == null) return list;

            list.AddRange(Modules);

            if (Modules.Count <= 0) return list;

            foreach (var module in Modules)
                list.AddRange(module.GetModules());

            return list;
        } 

        public void Initialize()
        {
            if (AutoScan)
            {
                var componentsPath = DirectoryPath + "/" + "Components";
                if (Directory.Exists(componentsPath))
                {
                    Components = new TList<TComponent>();
                    foreach (var fi in Directory.GetFiles(componentsPath, "*.js").Select(componentFile => new FileInfo(componentFile)))
                        Components.Add(new TComponent(fi.Name.Split(new []{'.'}, 2, StringSplitOptions.RemoveEmptyEntries)[0], fi.FullName));
                }

                var scriptsPath = DirectoryPath + "/" + "Scripts";
                if (Directory.Exists(componentsPath))
                {
                    Scripts = new TList<TScript>();
                    foreach (var fi in Directory.GetFiles(scriptsPath, "*.js").Select(componentFile => new FileInfo(componentFile)))
                        Scripts.Add(new TScript(fi.Name.Split(new[] { '.' }, 2, StringSplitOptions.RemoveEmptyEntries)[0], fi.FullName){ Included = true, Hidden = true });
                }
            }

            if (Modules != null && Modules.Count > 0)
                foreach (var module in Modules)
                    module.Initialize();
        }

        public override void Update()
        {
            if(Components != null)
                Components.Update();
            if (Modules != null)
                Modules.Update();
            if (Scenes != null)
                Scenes.Update();
            if(Scripts != null)
                Scripts.Update();
            if(Sounds != null)
                Sounds.Update();
            if(Sprites != null)
                Sprites.Update();
        }

        public override void Save()
        {
            if (Components != null)
                Components.Save();
            if (Modules != null)
                Modules.Save();
            if (Scenes != null)
                Scenes.Save();
            if (Scripts != null)
                Scripts.Save();
            if (Sounds != null)
                Sounds.Save();
            if (Sprites != null)
                Sprites.Save();
        }
    }
}
