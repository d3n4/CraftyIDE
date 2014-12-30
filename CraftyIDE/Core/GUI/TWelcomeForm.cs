using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using CraftyIDE.Core.Project;

namespace CraftyIDE.Core.GUI
{
    public partial class TWelcomeForm : Form
    {
        private readonly TIDEForm ideForm;

        public TWelcomeForm()
        {
            InitializeComponent();
            ideForm = new TIDEForm();
            ideForm.FormClosing += IdeFormOnClosed;
        }

        private void IdeFormOnClosed(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ideForm.Hide();
            Show();
            UpdateProjectsList();
        }

        private void TProjectList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var tag = (string) e.Node.Tag;
            if (tag == "new")
            {
                TProjectNameInput.Select();
                TProjectNameInput.Focus();
            }
            else if (tag == "import")
            {
                Debug.WriteLine("import PROJECT");
            }
        }

        private void ShowError(string message)
        {
            Height = 370;
            TErrorLabel.Text = @"     Error: " + message;
            TErrorLabel.Visible = true;
        }

        private void OpenProject(string projectName)
        {
            var project = TProject.Open(projectName);
            if (project == null)
            {
                ShowError("Project not exists");
                return;
            }
            ideForm.CurrentProject = project;
            ideForm.LoadProject();
            Hide();
            ideForm.Show();
        }

        private void CreateProcess(string projectName)
        {
            var result = TProject.Create(projectName);
            if (result == TProjectResult.Success)
            {
                OpenProject(projectName);
                return;
            }

            TProjectNameInput.Select();
            TProjectNameInput.Focus();

            if (result == TProjectResult.InvalidName)
            {
                ShowError("Invalid project name");
            }
            else if (result == TProjectResult.Exists)
            {
                ShowError("Project already exists");
            }
        }

        private void TCreateButton_Click(object sender, EventArgs e)
        {
            CreateProcess(TProjectNameInput.Text);
        }

        private void TWelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ideForm.Dispose();
        }

        private void UpdateProjectsList()
        {
            TRecentProjectList.Nodes.Clear();
            int index;
            var projects = Directory.GetDirectories(Environment.CurrentDirectory + "/Projects").Length;
            for (index = 0;
                index < projects;
                index++)
            {
                var projectDirectory = Directory.GetDirectories(Environment.CurrentDirectory + "/Projects")[index];
                var directoryInfo = new DirectoryInfo(projectDirectory);
                if (File.Exists(projectDirectory + "/properties.json"))
                    TRecentProjectList.Nodes.Add(directoryInfo.FullName, directoryInfo.Name, 1, 1);
            }
            TProjectNameInput.Text = "New Project " + (projects + 1);
        }

        private void TWelcomeForm_Shown(object sender, EventArgs e)
        {
            UpdateProjectsList();
        }

        private void TRecentProjectList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OpenProject(e.Node.Text);
        }

        private void TWelcomeForm_Load(object sender, EventArgs e)
        {
            TRecentProjectList.TreeViewNodeSorter = new DateSorter();
        }
    }
}
