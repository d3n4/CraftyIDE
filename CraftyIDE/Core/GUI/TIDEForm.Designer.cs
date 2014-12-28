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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0");
            this.TWebSession = new Awesomium.Windows.Forms.WebSessionProvider(this.components);
            this.TAmbianceContainer = new Ambiance_ThemeContainer();
            this.TIDEEditorContainer = new System.Windows.Forms.SplitContainer();
            this.TEditorContainerForm = new System.Windows.Forms.SplitContainer();
            this.TIDEEditorTabs = new Ambiance_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TEditorContainer = new System.Windows.Forms.SplitContainer();
            this.TEditorWebControl = new Awesomium.Windows.Forms.WebControl(this.components);
            this.TCodeEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TConsoleTree = new System.Windows.Forms.TreeView();
            this.ambiance_Separator1 = new Ambiance_Separator();
            this.ambiance_TrackBar1 = new Ambiance_TrackBar();
            this.ambiance_Button_16 = new Ambiance_Button_1();
            this.ambiance_Button_15 = new Ambiance_Button_1();
            this.ambiance_Button_14 = new Ambiance_Button_1();
            this.ambiance_Button_13 = new Ambiance_Button_1();
            this.ambiance_Button_12 = new Ambiance_Button_1();
            this.ambiance_Button_11 = new Ambiance_Button_1();
            this.TMenuSeparator = new Ambiance_Separator();
            this.TIDEProjectNPropertiesContainer = new System.Windows.Forms.SplitContainer();
            this.TProjectContainer = new System.Windows.Forms.SplitContainer();
            this.TProjectExplorer = new System.Windows.Forms.TreeView();
            this.TProjectComponents = new System.Windows.Forms.TreeView();
            this.TProperties = new System.Windows.Forms.PropertyGrid();
            this.TControlBox = new Ambiance_ControlBox();
            this.TCraftyLogo = new System.Windows.Forms.PictureBox();
            this.TAmbianceContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TIDEEditorContainer)).BeginInit();
            this.TIDEEditorContainer.Panel1.SuspendLayout();
            this.TIDEEditorContainer.Panel2.SuspendLayout();
            this.TIDEEditorContainer.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.TIDEProjectNPropertiesContainer)).BeginInit();
            this.TIDEProjectNPropertiesContainer.Panel1.SuspendLayout();
            this.TIDEProjectNPropertiesContainer.Panel2.SuspendLayout();
            this.TIDEProjectNPropertiesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TProjectContainer)).BeginInit();
            this.TProjectContainer.Panel1.SuspendLayout();
            this.TProjectContainer.Panel2.SuspendLayout();
            this.TProjectContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCraftyLogo)).BeginInit();
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
            this.TAmbianceContainer.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
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
            this.TIDEEditorContainer.Panel1.Controls.Add(this.TEditorContainerForm);
            this.TIDEEditorContainer.Panel1.Controls.Add(this.ambiance_Button_13);
            this.TIDEEditorContainer.Panel1.Controls.Add(this.ambiance_Button_12);
            this.TIDEEditorContainer.Panel1.Controls.Add(this.ambiance_Button_11);
            this.TIDEEditorContainer.Panel1.Controls.Add(this.TMenuSeparator);
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
            this.TEditorContainerForm.Panel2.Controls.Add(this.TConsoleTree);
            this.TEditorContainerForm.Panel2.Controls.Add(this.ambiance_Separator1);
            this.TEditorContainerForm.Panel2.Controls.Add(this.ambiance_TrackBar1);
            this.TEditorContainerForm.Panel2.Controls.Add(this.ambiance_Button_16);
            this.TEditorContainerForm.Panel2.Controls.Add(this.ambiance_Button_15);
            this.TEditorContainerForm.Panel2.Controls.Add(this.ambiance_Button_14);
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
            this.TCodeEditor.DelayedEventsInterval = 50;
            this.TCodeEditor.DelayedTextChangedInterval = 50;
            this.TCodeEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TCodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCodeEditor.FoldingIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
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
            // TConsoleTree
            // 
            this.TConsoleTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TConsoleTree.Location = new System.Drawing.Point(2, 46);
            this.TConsoleTree.Name = "TConsoleTree";
            this.TConsoleTree.Size = new System.Drawing.Size(541, 82);
            this.TConsoleTree.TabIndex = 14;
            // 
            // ambiance_Separator1
            // 
            this.ambiance_Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_Separator1.Location = new System.Drawing.Point(4, 34);
            this.ambiance_Separator1.Name = "ambiance_Separator1";
            this.ambiance_Separator1.Size = new System.Drawing.Size(544, 14);
            this.ambiance_Separator1.TabIndex = 15;
            this.ambiance_Separator1.Text = "ambiance_Separator1";
            // 
            // ambiance_TrackBar1
            // 
            this.ambiance_TrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_TrackBar1.DrawValueString = false;
            this.ambiance_TrackBar1.JumpToMouse = false;
            this.ambiance_TrackBar1.Location = new System.Drawing.Point(7, 11);
            this.ambiance_TrackBar1.Maximum = 10;
            this.ambiance_TrackBar1.Minimum = 0;
            this.ambiance_TrackBar1.MinimumSize = new System.Drawing.Size(47, 22);
            this.ambiance_TrackBar1.Name = "ambiance_TrackBar1";
            this.ambiance_TrackBar1.Size = new System.Drawing.Size(421, 22);
            this.ambiance_TrackBar1.TabIndex = 12;
            this.ambiance_TrackBar1.Text = "ambiance_TrackBar1";
            this.ambiance_TrackBar1.Value = 0;
            this.ambiance_TrackBar1.ValueDivison = Ambiance_TrackBar.ValueDivisor.By1;
            this.ambiance_TrackBar1.ValueToSet = 0F;
            // 
            // ambiance_Button_16
            // 
            this.ambiance_Button_16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_Button_16.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_16.Image = global::CraftyIDE.Properties.Resources.control_stop_square;
            this.ambiance_Button_16.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ambiance_Button_16.Location = new System.Drawing.Point(470, 8);
            this.ambiance_Button_16.Name = "ambiance_Button_16";
            this.ambiance_Button_16.Size = new System.Drawing.Size(30, 25);
            this.ambiance_Button_16.TabIndex = 9;
            this.ambiance_Button_16.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Button_15
            // 
            this.ambiance_Button_15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_Button_15.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_15.Image = global::CraftyIDE.Properties.Resources.control_record;
            this.ambiance_Button_15.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ambiance_Button_15.Location = new System.Drawing.Point(506, 8);
            this.ambiance_Button_15.Name = "ambiance_Button_15";
            this.ambiance_Button_15.Size = new System.Drawing.Size(30, 25);
            this.ambiance_Button_15.TabIndex = 10;
            this.ambiance_Button_15.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Button_14
            // 
            this.ambiance_Button_14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_Button_14.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_14.Image = global::CraftyIDE.Properties.Resources.control;
            this.ambiance_Button_14.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ambiance_Button_14.Location = new System.Drawing.Point(434, 8);
            this.ambiance_Button_14.Name = "ambiance_Button_14";
            this.ambiance_Button_14.Size = new System.Drawing.Size(30, 25);
            this.ambiance_Button_14.TabIndex = 11;
            this.ambiance_Button_14.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Button_13
            // 
            this.ambiance_Button_13.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_13.Image = global::CraftyIDE.Properties.Resources.compile;
            this.ambiance_Button_13.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ambiance_Button_13.Location = new System.Drawing.Point(79, 6);
            this.ambiance_Button_13.Name = "ambiance_Button_13";
            this.ambiance_Button_13.Size = new System.Drawing.Size(30, 25);
            this.ambiance_Button_13.TabIndex = 8;
            this.ambiance_Button_13.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Button_12
            // 
            this.ambiance_Button_12.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_12.Image = global::CraftyIDE.Properties.Resources.puzzle;
            this.ambiance_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ambiance_Button_12.Location = new System.Drawing.Point(43, 6);
            this.ambiance_Button_12.Name = "ambiance_Button_12";
            this.ambiance_Button_12.Size = new System.Drawing.Size(30, 25);
            this.ambiance_Button_12.TabIndex = 8;
            this.ambiance_Button_12.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = global::CraftyIDE.Properties.Resources.folder_horizontal;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ambiance_Button_11.Location = new System.Drawing.Point(7, 6);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(30, 25);
            this.ambiance_Button_11.TabIndex = 8;
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // TMenuSeparator
            // 
            this.TMenuSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TMenuSeparator.Location = new System.Drawing.Point(2, 32);
            this.TMenuSeparator.Name = "TMenuSeparator";
            this.TMenuSeparator.Size = new System.Drawing.Size(544, 14);
            this.TMenuSeparator.TabIndex = 0;
            this.TMenuSeparator.Text = "ambiance_Separator1";
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
            this.TProjectContainer.SplitterDistance = 150;
            this.TProjectContainer.TabIndex = 0;
            // 
            // TProjectExplorer
            // 
            this.TProjectExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TProjectExplorer.Location = new System.Drawing.Point(0, 0);
            this.TProjectExplorer.Name = "TProjectExplorer";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            this.TProjectExplorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.TProjectExplorer.Size = new System.Drawing.Size(206, 150);
            this.TProjectExplorer.TabIndex = 1;
            // 
            // TProjectComponents
            // 
            this.TProjectComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TProjectComponents.Location = new System.Drawing.Point(0, 0);
            this.TProjectComponents.Name = "TProjectComponents";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.TProjectComponents.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.TProjectComponents.Size = new System.Drawing.Size(206, 124);
            this.TProjectComponents.TabIndex = 2;
            // 
            // TProperties
            // 
            this.TProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TProperties.Location = new System.Drawing.Point(0, 0);
            this.TProperties.Name = "TProperties";
            this.TProperties.Size = new System.Drawing.Size(206, 246);
            this.TProperties.TabIndex = 8;
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
            // TIDEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TAmbianceContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "TIDEForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TIDEForm_FormClosing);
            this.Load += new System.EventHandler(this.TIDEForm_Load);
            this.Resize += new System.EventHandler(this.TIDEForm_Resize);
            this.TAmbianceContainer.ResumeLayout(false);
            this.TIDEEditorContainer.Panel1.ResumeLayout(false);
            this.TIDEEditorContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TIDEEditorContainer)).EndInit();
            this.TIDEEditorContainer.ResumeLayout(false);
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
            this.TIDEProjectNPropertiesContainer.Panel1.ResumeLayout(false);
            this.TIDEProjectNPropertiesContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TIDEProjectNPropertiesContainer)).EndInit();
            this.TIDEProjectNPropertiesContainer.ResumeLayout(false);
            this.TProjectContainer.Panel1.ResumeLayout(false);
            this.TProjectContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TProjectContainer)).EndInit();
            this.TProjectContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TCraftyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance_ThemeContainer TAmbianceContainer;
        private Ambiance_ControlBox TControlBox;
        private System.Windows.Forms.SplitContainer TIDEEditorContainer;
        private Ambiance_Button_1 ambiance_Button_11;
        private Ambiance_Separator TMenuSeparator;
        private System.Windows.Forms.SplitContainer TIDEProjectNPropertiesContainer;
        private System.Windows.Forms.PropertyGrid TProperties;
        private Awesomium.Windows.Forms.WebSessionProvider TWebSession;
        private System.Windows.Forms.PictureBox TCraftyLogo;
        private System.Windows.Forms.SplitContainer TEditorContainerForm;
        private Ambiance_Button_1 ambiance_Button_12;
        private Ambiance_Button_1 ambiance_Button_13;
        private Ambiance_Button_1 ambiance_Button_16;
        private Ambiance_Button_1 ambiance_Button_15;
        private Ambiance_Button_1 ambiance_Button_14;
        private Ambiance_TrackBar ambiance_TrackBar1;
        private Ambiance_Separator ambiance_Separator1;
        private System.Windows.Forms.TreeView TConsoleTree;
        private Ambiance_TabControl TIDEEditorTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer TEditorContainer;
        private System.Windows.Forms.TabPage tabPage2;
        private FastColoredTextBoxNS.FastColoredTextBox TCodeEditor;
        private Awesomium.Windows.Forms.WebControl TEditorWebControl;
        private SplitContainer TProjectContainer;
        private TreeView TProjectExplorer;
        private TreeView TProjectComponents;
    }
}

