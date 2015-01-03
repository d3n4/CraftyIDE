using System.Drawing;
using System.Windows.Forms;

namespace CraftyIDE.Core.GUI
{
    partial class TIDEForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Awesomium.Core.WebPreferences webPreferences1 = new Awesomium.Core.WebPreferences(true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TIDEForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            this.TWebSession = new Awesomium.Windows.Forms.WebSessionProvider(this.components);
            this.TProjectExplorerImageList = new System.Windows.Forms.ImageList(this.components);
            this.TAmbianceContainer = new Ambiance_ThemeContainer();
            this.TIDEEditorContainer = new System.Windows.Forms.SplitContainer();
            this.TMenuSeparator = new Ambiance_Separator();
            this.TMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.TMainMenuUtilsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.TMainMenuToolboxButton = new System.Windows.Forms.ToolStripButton();
            this.TProjectMainMenuSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TEditorContainerForm = new System.Windows.Forms.SplitContainer();
            this.TIDEEditorTabs = new Ambiance_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TEditorContainer = new System.Windows.Forms.SplitContainer();
            this.TEditorWebControl = new Awesomium.Windows.Forms.WebControl(this.components);
            this.TCodeEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TUtilsTabs = new Ambiance_TabControl();
            this.TUtilsConsolePage = new System.Windows.Forms.TabPage();
            this.TConsoleTree = new System.Windows.Forms.TreeView();
            this.TUtilsPlaybackPage = new System.Windows.Forms.TabPage();
            this.TPlaybackRecordsTree = new System.Windows.Forms.TreeView();
            this.TPlaybackSeparator = new Ambiance_Separator();
            this.TPlaybackControlsPanel = new System.Windows.Forms.Panel();
            this.TPlaybackControlsStrip = new System.Windows.Forms.ToolStrip();
            this.TPlaybackPlayButton = new System.Windows.Forms.ToolStripButton();
            this.TPlaybackStopButton = new System.Windows.Forms.ToolStripButton();
            this.TPlaybackRecordButton = new System.Windows.Forms.ToolStripButton();
            this.TPlaybackTrack = new Ambiance_TrackBar();
            this.TIDEProjectNPropertiesContainer = new System.Windows.Forms.SplitContainer();
            this.TProjectContainer = new System.Windows.Forms.SplitContainer();
            this.TProjectExplorer = new System.Windows.Forms.TreeView();
            this.TProjectComponents = new System.Windows.Forms.TreeView();
            this.TProperties = new System.Windows.Forms.PropertyGrid();
            this.TControlBox = new Ambiance_ControlBox();
            this.TCraftyLogo = new System.Windows.Forms.PictureBox();
            this.TComponentsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TModulesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TAmbianceContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TIDEEditorContainer)).BeginInit();
            this.TIDEEditorContainer.Panel1.SuspendLayout();
            this.TIDEEditorContainer.Panel2.SuspendLayout();
            this.TIDEEditorContainer.SuspendLayout();
            this.TMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEditorContainerForm)).BeginInit();
            this.TEditorContainerForm.Panel1.SuspendLayout();
            this.TEditorContainerForm.Panel2.SuspendLayout();
            this.TEditorContainerForm.SuspendLayout();
            this.TIDEEditorTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEditorContainer)).BeginInit();
            this.TEditorContainer.Panel1.SuspendLayout();
            this.TEditorContainer.Panel2.SuspendLayout();
            this.TEditorContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCodeEditor)).BeginInit();
            this.TUtilsTabs.SuspendLayout();
            this.TUtilsConsolePage.SuspendLayout();
            this.TUtilsPlaybackPage.SuspendLayout();
            this.TPlaybackControlsPanel.SuspendLayout();
            this.TPlaybackControlsStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TIDEProjectNPropertiesContainer)).BeginInit();
            this.TIDEProjectNPropertiesContainer.Panel1.SuspendLayout();
            this.TIDEProjectNPropertiesContainer.Panel2.SuspendLayout();
            this.TIDEProjectNPropertiesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TProjectContainer)).BeginInit();
            this.TProjectContainer.Panel1.SuspendLayout();
            this.TProjectContainer.Panel2.SuspendLayout();
            this.TProjectContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCraftyLogo)).BeginInit();
            this.TComponentsContextMenu.SuspendLayout();
            this.TModulesContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TWebSession
            // 
            webPreferences1.AppCache = false;
            webPreferences1.CanScriptsCloseWindows = false;
            webPreferences1.CanScriptsOpenWindows = false;
            webPreferences1.Dart = false;
            webPreferences1.EnableGPUAcceleration = true;
            webPreferences1.Plugins = false;
            webPreferences1.SmoothScrolling = true;
            webPreferences1.WebGL = true;
            this.TWebSession.Preferences = webPreferences1;
            // 
            // TProjectExplorerImageList
            // 
            this.TProjectExplorerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TProjectExplorerImageList.ImageStream")));
            this.TProjectExplorerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TProjectExplorerImageList.Images.SetKeyName(0, "blue-folder-horizontal.png");
            this.TProjectExplorerImageList.Images.SetKeyName(1, "block.png");
            this.TProjectExplorerImageList.Images.SetKeyName(2, "box.png");
            this.TProjectExplorerImageList.Images.SetKeyName(3, "script.png");
            this.TProjectExplorerImageList.Images.SetKeyName(4, "sport-soccer.png");
            // 
            // TAmbianceContainer
            // 
            this.TAmbianceContainer.BackColor = System.Drawing.SystemColors.Control;
            this.TAmbianceContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TAmbianceContainer.BackgroundImage")));
            this.TAmbianceContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TAmbianceContainer.Controls.Add(this.TIDEEditorContainer);
            this.TAmbianceContainer.Controls.Add(this.TControlBox);
            this.TAmbianceContainer.Controls.Add(this.TCraftyLogo);
            this.TAmbianceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TAmbianceContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TAmbianceContainer.Location = new System.Drawing.Point(0, 0);
            this.TAmbianceContainer.Name = "TAmbianceContainer";
            this.TAmbianceContainer.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.TAmbianceContainer.RoundCorners = true;
            this.TAmbianceContainer.Sizable = true;
            this.TAmbianceContainer.Size = new System.Drawing.Size(800, 600);
            this.TAmbianceContainer.SmartBounds = true;
            this.TAmbianceContainer.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TAmbianceContainer.TabIndex = 2;
            // 
            // TIDEEditorContainer
            // 
            this.TIDEEditorContainer.BackColor = System.Drawing.SystemColors.Control;
            this.TIDEEditorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TIDEEditorContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.TIDEEditorContainer.Location = new System.Drawing.Point(20, 56);
            this.TIDEEditorContainer.Name = "TIDEEditorContainer";
            // 
            // TIDEEditorContainer.Panel1
            // 
            this.TIDEEditorContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.TIDEEditorContainer.Panel1.Controls.Add(this.TMenuSeparator);
            this.TIDEEditorContainer.Panel1.Controls.Add(this.TMainMenu);
            this.TIDEEditorContainer.Panel1.Controls.Add(this.TEditorContainerForm);
            this.TIDEEditorContainer.Panel1MinSize = 50;
            // 
            // TIDEEditorContainer.Panel2
            // 
            this.TIDEEditorContainer.Panel2.Controls.Add(this.TIDEProjectNPropertiesContainer);
            this.TIDEEditorContainer.Panel2MinSize = 50;
            this.TIDEEditorContainer.Size = new System.Drawing.Size(760, 528);
            this.TIDEEditorContainer.SplitterDistance = 550;
            this.TIDEEditorContainer.TabIndex = 6;
            // 
            // TMenuSeparator
            // 
            this.TMenuSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TMenuSeparator.Location = new System.Drawing.Point(1, 21);
            this.TMenuSeparator.Name = "TMenuSeparator";
            this.TMenuSeparator.Size = new System.Drawing.Size(552, 14);
            this.TMenuSeparator.TabIndex = 0;
            this.TMenuSeparator.Text = "ambiance_Separator1";
            // 
            // TMainMenu
            // 
            this.TMainMenu.GripMargin = new System.Windows.Forms.Padding(10);
            this.TMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.TMainMenuUtilsButton,
            this.toolStripButton4,
            this.TMainMenuToolboxButton,
            this.TProjectMainMenuSave,
            this.toolStripDropDownButton1});
            this.TMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.TMainMenu.Location = new System.Drawing.Point(0, 0);
            this.TMainMenu.Name = "TMainMenu";
            this.TMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TMainMenu.Size = new System.Drawing.Size(550, 23);
            this.TMainMenu.TabIndex = 10;
            this.TMainMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CraftyIDE.Properties.Resources.folder_horizontal;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::CraftyIDE.Properties.Resources.compile;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // TMainMenuUtilsButton
            // 
            this.TMainMenuUtilsButton.Checked = true;
            this.TMainMenuUtilsButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TMainMenuUtilsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TMainMenuUtilsButton.Image = global::CraftyIDE.Properties.Resources.bug;
            this.TMainMenuUtilsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TMainMenuUtilsButton.Name = "TMainMenuUtilsButton";
            this.TMainMenuUtilsButton.Size = new System.Drawing.Size(23, 20);
            this.TMainMenuUtilsButton.Text = "Console";
            this.TMainMenuUtilsButton.Click += new System.EventHandler(this.TMainMenuUtilsButton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::CraftyIDE.Properties.Resources.blue_folder_tree;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // TMainMenuToolboxButton
            // 
            this.TMainMenuToolboxButton.Checked = true;
            this.TMainMenuToolboxButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TMainMenuToolboxButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TMainMenuToolboxButton.Image = global::CraftyIDE.Properties.Resources.toolbox;
            this.TMainMenuToolboxButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TMainMenuToolboxButton.Name = "TMainMenuToolboxButton";
            this.TMainMenuToolboxButton.Size = new System.Drawing.Size(23, 20);
            this.TMainMenuToolboxButton.Text = "Project Toolbox";
            this.TMainMenuToolboxButton.Click += new System.EventHandler(this.TMainMenuToolboxButton_Click);
            // 
            // TProjectMainMenuSave
            // 
            this.TProjectMainMenuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TProjectMainMenuSave.Image = global::CraftyIDE.Properties.Resources.disk;
            this.TProjectMainMenuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TProjectMainMenuSave.Name = "TProjectMainMenuSave";
            this.TProjectMainMenuSave.Size = new System.Drawing.Size(23, 20);
            this.TProjectMainMenuSave.Text = "toolStripButton5";
            this.TProjectMainMenuSave.Click += new System.EventHandler(this.TProjectMainMenuSave_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.testToolStripMenuItem.Text = "test";
            // 
            // TEditorContainerForm
            // 
            this.TEditorContainerForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEditorContainerForm.BackColor = System.Drawing.SystemColors.Control;
            this.TEditorContainerForm.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.TEditorContainerForm.Location = new System.Drawing.Point(5, 42);
            this.TEditorContainerForm.Name = "TEditorContainerForm";
            this.TEditorContainerForm.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TEditorContainerForm.Panel1
            // 
            this.TEditorContainerForm.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.TEditorContainerForm.Panel1.Controls.Add(this.TIDEEditorTabs);
            // 
            // TEditorContainerForm.Panel2
            // 
            this.TEditorContainerForm.Panel2.Controls.Add(this.TUtilsTabs);
            this.TEditorContainerForm.Panel2MinSize = 60;
            this.TEditorContainerForm.Size = new System.Drawing.Size(543, 483);
            this.TEditorContainerForm.SplitterDistance = 350;
            this.TEditorContainerForm.TabIndex = 9;
            // 
            // TIDEEditorTabs
            // 
            this.TIDEEditorTabs.Controls.Add(this.tabPage1);
            this.TIDEEditorTabs.Controls.Add(this.tabPage2);
            this.TIDEEditorTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TIDEEditorTabs.ItemSize = new System.Drawing.Size(80, 24);
            this.TIDEEditorTabs.Location = new System.Drawing.Point(0, 0);
            this.TIDEEditorTabs.Name = "TIDEEditorTabs";
            this.TIDEEditorTabs.SelectedIndex = 0;
            this.TIDEEditorTabs.Size = new System.Drawing.Size(543, 350);
            this.TIDEEditorTabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.TEditorContainer);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editor";
            // 
            // TEditorContainer
            // 
            this.TEditorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TEditorContainer.Location = new System.Drawing.Point(3, 3);
            this.TEditorContainer.Name = "TEditorContainer";
            // 
            // TEditorContainer.Panel1
            // 
            this.TEditorContainer.Panel1.Controls.Add(this.TEditorWebControl);
            // 
            // TEditorContainer.Panel2
            // 
            this.TEditorContainer.Panel2.Controls.Add(this.TCodeEditor);
            this.TEditorContainer.Size = new System.Drawing.Size(529, 312);
            this.TEditorContainer.SplitterDistance = 280;
            this.TEditorContainer.TabIndex = 1;
            // 
            // TEditorWebControl
            // 
            this.TEditorWebControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TEditorWebControl.Location = new System.Drawing.Point(0, 0);
            this.TEditorWebControl.Size = new System.Drawing.Size(280, 312);
            this.TEditorWebControl.Source = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.TEditorWebControl.TabIndex = 10;
            this.TEditorWebControl.ViewType = Awesomium.Core.WebViewType.Offscreen;
            // 
            // TCodeEditor
            // 
            this.TCodeEditor.AutoCompleteBrackets = true;
            this.TCodeEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.TCodeEditor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.TCodeEditor.AutoScrollMinSize = new System.Drawing.Size(417, 154);
            this.TCodeEditor.BackBrush = null;
            this.TCodeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TCodeEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TCodeEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.TCodeEditor.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.TCodeEditor.CharHeight = 14;
            this.TCodeEditor.CharWidth = 7;
            this.TCodeEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCodeEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TCodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCodeEditor.FoldingIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.TCodeEditor.Font = new System.Drawing.Font("Consolas", 9F);
            this.TCodeEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TCodeEditor.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.TCodeEditor.IsReplaceMode = false;
            this.TCodeEditor.Language = FastColoredTextBoxNS.Language.JS;
            this.TCodeEditor.LeftBracket = '(';
            this.TCodeEditor.LeftBracket2 = '{';
            this.TCodeEditor.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.TCodeEditor.Location = new System.Drawing.Point(0, 0);
            this.TCodeEditor.Name = "TCodeEditor";
            this.TCodeEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.TCodeEditor.ReservedCountOfLineNumberChars = 3;
            this.TCodeEditor.RightBracket = ')';
            this.TCodeEditor.RightBracket2 = '}';
            this.TCodeEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.TCodeEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("TCodeEditor.ServiceColors")));
            this.TCodeEditor.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.TCodeEditor.Size = new System.Drawing.Size(245, 312);
            this.TCodeEditor.TabIndex = 0;
            this.TCodeEditor.TabLength = 3;
            this.TCodeEditor.Text = resources.GetString("TCodeEditor.Text");
            this.TCodeEditor.TextAreaBorderColor = System.Drawing.Color.Transparent;
            this.TCodeEditor.Zoom = 100;
            this.TCodeEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.TCodeEditor_TextChanged);
            this.TCodeEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TCodeEditor_MouseDown);
            this.TCodeEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TCodeEditor_MouseMove);
            this.TCodeEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TCodeEditor_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game";
            // 
            // TUtilsTabs
            // 
            this.TUtilsTabs.Controls.Add(this.TUtilsConsolePage);
            this.TUtilsTabs.Controls.Add(this.TUtilsPlaybackPage);
            this.TUtilsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TUtilsTabs.ItemSize = new System.Drawing.Size(80, 24);
            this.TUtilsTabs.Location = new System.Drawing.Point(0, 0);
            this.TUtilsTabs.Name = "TUtilsTabs";
            this.TUtilsTabs.SelectedIndex = 0;
            this.TUtilsTabs.Size = new System.Drawing.Size(543, 129);
            this.TUtilsTabs.TabIndex = 0;
            // 
            // TUtilsConsolePage
            // 
            this.TUtilsConsolePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.TUtilsConsolePage.Controls.Add(this.TConsoleTree);
            this.TUtilsConsolePage.Location = new System.Drawing.Point(4, 28);
            this.TUtilsConsolePage.Name = "TUtilsConsolePage";
            this.TUtilsConsolePage.Padding = new System.Windows.Forms.Padding(3);
            this.TUtilsConsolePage.Size = new System.Drawing.Size(535, 97);
            this.TUtilsConsolePage.TabIndex = 0;
            this.TUtilsConsolePage.Text = "Console";
            // 
            // TConsoleTree
            // 
            this.TConsoleTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TConsoleTree.Location = new System.Drawing.Point(3, 3);
            this.TConsoleTree.Name = "TConsoleTree";
            this.TConsoleTree.Size = new System.Drawing.Size(529, 91);
            this.TConsoleTree.TabIndex = 27;
            // 
            // TUtilsPlaybackPage
            // 
            this.TUtilsPlaybackPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.TUtilsPlaybackPage.Controls.Add(this.TPlaybackRecordsTree);
            this.TUtilsPlaybackPage.Controls.Add(this.TPlaybackSeparator);
            this.TUtilsPlaybackPage.Controls.Add(this.TPlaybackControlsPanel);
            this.TUtilsPlaybackPage.Location = new System.Drawing.Point(4, 28);
            this.TUtilsPlaybackPage.Name = "TUtilsPlaybackPage";
            this.TUtilsPlaybackPage.Padding = new System.Windows.Forms.Padding(3);
            this.TUtilsPlaybackPage.Size = new System.Drawing.Size(535, 97);
            this.TUtilsPlaybackPage.TabIndex = 1;
            this.TUtilsPlaybackPage.Text = "Playback";
            // 
            // TPlaybackRecordsTree
            // 
            this.TPlaybackRecordsTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TPlaybackRecordsTree.Location = new System.Drawing.Point(4, 37);
            this.TPlaybackRecordsTree.Name = "TPlaybackRecordsTree";
            this.TPlaybackRecordsTree.Size = new System.Drawing.Size(527, 57);
            this.TPlaybackRecordsTree.TabIndex = 5;
            // 
            // TPlaybackSeparator
            // 
            this.TPlaybackSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TPlaybackSeparator.Location = new System.Drawing.Point(-8, 25);
            this.TPlaybackSeparator.Name = "TPlaybackSeparator";
            this.TPlaybackSeparator.Size = new System.Drawing.Size(552, 14);
            this.TPlaybackSeparator.TabIndex = 4;
            this.TPlaybackSeparator.Text = "ambiance_Separator1";
            // 
            // TPlaybackControlsPanel
            // 
            this.TPlaybackControlsPanel.Controls.Add(this.TPlaybackControlsStrip);
            this.TPlaybackControlsPanel.Controls.Add(this.TPlaybackTrack);
            this.TPlaybackControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TPlaybackControlsPanel.Location = new System.Drawing.Point(3, 3);
            this.TPlaybackControlsPanel.Name = "TPlaybackControlsPanel";
            this.TPlaybackControlsPanel.Size = new System.Drawing.Size(529, 29);
            this.TPlaybackControlsPanel.TabIndex = 3;
            // 
            // TPlaybackControlsStrip
            // 
            this.TPlaybackControlsStrip.BackColor = System.Drawing.Color.Transparent;
            this.TPlaybackControlsStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.TPlaybackControlsStrip.GripMargin = new System.Windows.Forms.Padding(10);
            this.TPlaybackControlsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TPlaybackPlayButton,
            this.TPlaybackStopButton,
            this.TPlaybackRecordButton});
            this.TPlaybackControlsStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.TPlaybackControlsStrip.Location = new System.Drawing.Point(459, 0);
            this.TPlaybackControlsStrip.Name = "TPlaybackControlsStrip";
            this.TPlaybackControlsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TPlaybackControlsStrip.Size = new System.Drawing.Size(70, 29);
            this.TPlaybackControlsStrip.TabIndex = 33;
            this.TPlaybackControlsStrip.Text = "toolStrip2";
            // 
            // TPlaybackPlayButton
            // 
            this.TPlaybackPlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TPlaybackPlayButton.Image = global::CraftyIDE.Properties.Resources.control;
            this.TPlaybackPlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TPlaybackPlayButton.Name = "TPlaybackPlayButton";
            this.TPlaybackPlayButton.Size = new System.Drawing.Size(23, 20);
            this.TPlaybackPlayButton.Text = "Play";
            // 
            // TPlaybackStopButton
            // 
            this.TPlaybackStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TPlaybackStopButton.Image = global::CraftyIDE.Properties.Resources.control_stop_square;
            this.TPlaybackStopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TPlaybackStopButton.Name = "TPlaybackStopButton";
            this.TPlaybackStopButton.Size = new System.Drawing.Size(23, 20);
            this.TPlaybackStopButton.Text = "Stop";
            // 
            // TPlaybackRecordButton
            // 
            this.TPlaybackRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TPlaybackRecordButton.Image = global::CraftyIDE.Properties.Resources.control_record;
            this.TPlaybackRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TPlaybackRecordButton.Name = "TPlaybackRecordButton";
            this.TPlaybackRecordButton.Size = new System.Drawing.Size(23, 20);
            this.TPlaybackRecordButton.Text = "Record";
            // 
            // TPlaybackTrack
            // 
            this.TPlaybackTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TPlaybackTrack.DrawValueString = false;
            this.TPlaybackTrack.JumpToMouse = false;
            this.TPlaybackTrack.Location = new System.Drawing.Point(6, 0);
            this.TPlaybackTrack.Maximum = 10;
            this.TPlaybackTrack.Minimum = 0;
            this.TPlaybackTrack.MinimumSize = new System.Drawing.Size(47, 22);
            this.TPlaybackTrack.Name = "TPlaybackTrack";
            this.TPlaybackTrack.Size = new System.Drawing.Size(451, 22);
            this.TPlaybackTrack.TabIndex = 32;
            this.TPlaybackTrack.Text = "ambiance_TrackBar1";
            this.TPlaybackTrack.Value = 0;
            this.TPlaybackTrack.ValueDivison = Ambiance_TrackBar.ValueDivisor.By1;
            this.TPlaybackTrack.ValueToSet = 0F;
            // 
            // TIDEProjectNPropertiesContainer
            // 
            this.TIDEProjectNPropertiesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TIDEProjectNPropertiesContainer.Location = new System.Drawing.Point(0, 0);
            this.TIDEProjectNPropertiesContainer.Name = "TIDEProjectNPropertiesContainer";
            this.TIDEProjectNPropertiesContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TIDEProjectNPropertiesContainer.Panel1
            // 
            this.TIDEProjectNPropertiesContainer.Panel1.Controls.Add(this.TProjectContainer);
            this.TIDEProjectNPropertiesContainer.Panel1MinSize = 100;
            // 
            // TIDEProjectNPropertiesContainer.Panel2
            // 
            this.TIDEProjectNPropertiesContainer.Panel2.Controls.Add(this.TProperties);
            this.TIDEProjectNPropertiesContainer.Panel2MinSize = 100;
            this.TIDEProjectNPropertiesContainer.Size = new System.Drawing.Size(206, 528);
            this.TIDEProjectNPropertiesContainer.SplitterDistance = 278;
            this.TIDEProjectNPropertiesContainer.TabIndex = 0;
            // 
            // TProjectContainer
            // 
            this.TProjectContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TProjectContainer.Location = new System.Drawing.Point(0, 0);
            this.TProjectContainer.Name = "TProjectContainer";
            this.TProjectContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TProjectContainer.Panel1
            // 
            this.TProjectContainer.Panel1.Controls.Add(this.TProjectExplorer);
            // 
            // TProjectContainer.Panel2
            // 
            this.TProjectContainer.Panel2.Controls.Add(this.TProjectComponents);
            this.TProjectContainer.Size = new System.Drawing.Size(206, 278);
            this.TProjectContainer.SplitterDistance = 149;
            this.TProjectContainer.TabIndex = 3;
            // 
            // TProjectExplorer
            // 
            this.TProjectExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TProjectExplorer.ImageIndex = 0;
            this.TProjectExplorer.ImageList = this.TProjectExplorerImageList;
            this.TProjectExplorer.Location = new System.Drawing.Point(0, 0);
            this.TProjectExplorer.Name = "TProjectExplorer";
            this.TProjectExplorer.SelectedImageIndex = 0;
            this.TProjectExplorer.Size = new System.Drawing.Size(206, 149);
            this.TProjectExplorer.TabIndex = 6;
            this.TProjectExplorer.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TProjectExplorer_AfterCollapse);
            this.TProjectExplorer.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TProjectExplorer_AfterExpand);
            this.TProjectExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TProjectExplorer_AfterSelect);
            this.TProjectExplorer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TProjectExplorer_MouseClick);
            // 
            // TProjectComponents
            // 
            this.TProjectComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TProjectComponents.Location = new System.Drawing.Point(0, 0);
            this.TProjectComponents.Name = "TProjectComponents";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            this.TProjectComponents.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.TProjectComponents.Size = new System.Drawing.Size(206, 125);
            this.TProjectComponents.TabIndex = 5;
            // 
            // TProperties
            // 
            this.TProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TProperties.Location = new System.Drawing.Point(0, 0);
            this.TProperties.Name = "TProperties";
            this.TProperties.Size = new System.Drawing.Size(206, 246);
            this.TProperties.TabIndex = 8;
            this.TProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.TProperties_PropertyValueChanged);
            // 
            // TControlBox
            // 
            this.TControlBox.BackColor = System.Drawing.Color.Transparent;
            this.TControlBox.EnableMaximize = true;
            this.TControlBox.Font = new System.Drawing.Font("Marlett", 7F);
            this.TControlBox.Location = new System.Drawing.Point(5, 13);
            this.TControlBox.Name = "TControlBox";
            this.TControlBox.Size = new System.Drawing.Size(64, 22);
            this.TControlBox.TabIndex = 3;
            this.TControlBox.Text = "ControlBox";
            // 
            // TCraftyLogo
            // 
            this.TCraftyLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TCraftyLogo.BackColor = System.Drawing.Color.Transparent;
            this.TCraftyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TCraftyLogo.Image = ((System.Drawing.Image)(resources.GetObject("TCraftyLogo.Image")));
            this.TCraftyLogo.Location = new System.Drawing.Point(335, 2);
            this.TCraftyLogo.Name = "TCraftyLogo";
            this.TCraftyLogo.Size = new System.Drawing.Size(120, 41);
            this.TCraftyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TCraftyLogo.TabIndex = 7;
            this.TCraftyLogo.TabStop = false;
            // 
            // TComponentsContextMenu
            // 
            this.TComponentsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComponentToolStripMenuItem});
            this.TComponentsContextMenu.Name = "TComponentsContextMenu";
            this.TComponentsContextMenu.Size = new System.Drawing.Size(162, 26);
            // 
            // addComponentToolStripMenuItem
            // 
            this.addComponentToolStripMenuItem.Name = "addComponentToolStripMenuItem";
            this.addComponentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addComponentToolStripMenuItem.Text = "Add component";
            this.addComponentToolStripMenuItem.Click += new System.EventHandler(this.addComponentToolStripMenuItem_Click);
            // 
            // TModulesContextMenu
            // 
            this.TModulesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModuleToolStripMenuItem});
            this.TModulesContextMenu.Name = "TModulesContextMenu";
            this.TModulesContextMenu.Size = new System.Drawing.Size(141, 26);
            // 
            // addModuleToolStripMenuItem
            // 
            this.addModuleToolStripMenuItem.Name = "addModuleToolStripMenuItem";
            this.addModuleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addModuleToolStripMenuItem.Text = "Add module";
            this.addModuleToolStripMenuItem.Click += new System.EventHandler(this.addModuleToolStripMenuItem_Click);
            // 
            // TIDEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TAmbianceContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TIDEForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TIDEForm_FormClosing);
            this.Load += new System.EventHandler(this.TIDEForm_Load);
            this.Resize += new System.EventHandler(this.TIDEForm_Resize);
            this.TAmbianceContainer.ResumeLayout(false);
            this.TIDEEditorContainer.Panel1.ResumeLayout(false);
            this.TIDEEditorContainer.Panel1.PerformLayout();
            this.TIDEEditorContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TIDEEditorContainer)).EndInit();
            this.TIDEEditorContainer.ResumeLayout(false);
            this.TMainMenu.ResumeLayout(false);
            this.TMainMenu.PerformLayout();
            this.TEditorContainerForm.Panel1.ResumeLayout(false);
            this.TEditorContainerForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TEditorContainerForm)).EndInit();
            this.TEditorContainerForm.ResumeLayout(false);
            this.TIDEEditorTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TEditorContainer.Panel1.ResumeLayout(false);
            this.TEditorContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TEditorContainer)).EndInit();
            this.TEditorContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TCodeEditor)).EndInit();
            this.TUtilsTabs.ResumeLayout(false);
            this.TUtilsConsolePage.ResumeLayout(false);
            this.TUtilsPlaybackPage.ResumeLayout(false);
            this.TPlaybackControlsPanel.ResumeLayout(false);
            this.TPlaybackControlsPanel.PerformLayout();
            this.TPlaybackControlsStrip.ResumeLayout(false);
            this.TPlaybackControlsStrip.PerformLayout();
            this.TIDEProjectNPropertiesContainer.Panel1.ResumeLayout(false);
            this.TIDEProjectNPropertiesContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TIDEProjectNPropertiesContainer)).EndInit();
            this.TIDEProjectNPropertiesContainer.ResumeLayout(false);
            this.TProjectContainer.Panel1.ResumeLayout(false);
            this.TProjectContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TProjectContainer)).EndInit();
            this.TProjectContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TCraftyLogo)).EndInit();
            this.TComponentsContextMenu.ResumeLayout(false);
            this.TModulesContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance_ThemeContainer TAmbianceContainer;
        private Ambiance_ControlBox TControlBox;
        private System.Windows.Forms.SplitContainer TIDEEditorContainer;
        private Ambiance_Separator TMenuSeparator;
        private System.Windows.Forms.SplitContainer TIDEProjectNPropertiesContainer;
        private System.Windows.Forms.PropertyGrid TProperties;
        private Awesomium.Windows.Forms.WebSessionProvider TWebSession;
        private System.Windows.Forms.PictureBox TCraftyLogo;
        private System.Windows.Forms.SplitContainer TEditorContainerForm;
        private Ambiance_TabControl TIDEEditorTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer TEditorContainer;
        private System.Windows.Forms.TabPage tabPage2;
        private FastColoredTextBoxNS.FastColoredTextBox TCodeEditor;
        private Awesomium.Windows.Forms.WebControl TEditorWebControl;
        private ToolStrip TMainMenu;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton TMainMenuUtilsButton;
        private SplitContainer TProjectContainer;
        private ToolStripButton toolStripButton4;
        private TreeView TProjectComponents;
        private ToolStripButton TMainMenuToolboxButton;
        private Ambiance_TabControl TUtilsTabs;
        private TabPage TUtilsConsolePage;
        private TreeView TConsoleTree;
        private TabPage TUtilsPlaybackPage;
        private Panel TPlaybackControlsPanel;
        private ToolStrip TPlaybackControlsStrip;
        private ToolStripButton TPlaybackPlayButton;
        private ToolStripButton TPlaybackStopButton;
        private ToolStripButton TPlaybackRecordButton;
        private Ambiance_TrackBar TPlaybackTrack;
        private TreeView TProjectExplorer;
        private ToolStripButton TProjectMainMenuSave;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem testToolStripMenuItem;
        private Ambiance_Separator TPlaybackSeparator;
        private TreeView TPlaybackRecordsTree;
        private ImageList TProjectExplorerImageList;
        private ContextMenuStrip TComponentsContextMenu;
        private ToolStripMenuItem addComponentToolStripMenuItem;
        private ContextMenuStrip TModulesContextMenu;
        private ToolStripMenuItem addModuleToolStripMenuItem;
    }
}

