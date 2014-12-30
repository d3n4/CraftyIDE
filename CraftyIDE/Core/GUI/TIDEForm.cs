using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CraftyIDE.Core.Project;
using FastColoredTextBoxNS;
using RubberGameIDE;

namespace CraftyIDE.Core.GUI
{
    public partial class TIDEForm : Form
    {
        public TIDEForm()
        {
            InitializeComponent();

            TCodeEditor.SyntaxHighlighter.AttributeStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(70, 225, 170)), null, FontStyle.Regular);
            TCodeEditor.SyntaxHighlighter.ClassNameStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(180, 0, 0)), null, FontStyle.Regular);
            TCodeEditor.SyntaxHighlighter.CommentStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(130, 140, 140)), null, FontStyle.Italic);
            TCodeEditor.SyntaxHighlighter.CommentTagStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(130, 140, 140)), null, FontStyle.Italic);
            TCodeEditor.SyntaxHighlighter.KeywordStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(155, 205, 50)), null, FontStyle.Regular | FontStyle.Bold);
            TCodeEditor.SyntaxHighlighter.NumberStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(240, 255, 0)), null, FontStyle.Regular);
            TCodeEditor.SyntaxHighlighter.StringStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(225, 130, 0)), null, FontStyle.Regular | FontStyle.Bold);
            UpdateCodeEditor();
        }

        public TProject CurrentProject;

        private void UpdateCodeEditor()
        {
            var buffer = TCodeEditor.Text;
            TCodeEditor.Text = "";
            TCodeEditor.Text = buffer;
        }

        public void UpdateProjectExplorer()
        {
            //SaveProjectTreeState();
            TProjectExplorer.Nodes.Clear();

            var projectNode = new TProjectTreeNode
            {
                Text = CurrentProject.Name,
                PropObject = CurrentProject,
                ImageIndex = 0,
                SelectedImageIndex = 0
            };
            TProjectExplorer.Nodes.Add(projectNode);

            var componentsNode = new TProjectTreeNode
            {
                Text = "Components",
                PropObject = CurrentProject.Components,
                ImageIndex = 1,
                SelectedImageIndex = 1
            };
            projectNode.Nodes.Add(componentsNode);

            foreach (var component in CurrentProject.Components)
                componentsNode.Nodes.Add(new TProjectTreeNode
                {
                    Text = component.Name,
                    PropObject = component,
                    ImageIndex = 1,
                    SelectedImageIndex = 1
                });
        }

        public void Save()
        {
            SaveProjectTreeState();
            CurrentProject.Save();
        }

        public void LoadProject()
        {
            TProperties.SelectedObject = CurrentProject;
            UpdateProjectExplorer();
            RestoreProjectTreeState();
        }

        private void SaveProjectTreeState()
        {
            if (CurrentProject.ProjectTreeState != null)
            {
                CurrentProject.ProjectTreeState.Clear();
                CurrentProject.ProjectTreeState = null;
            }
            var nodes = AllNodes(TProjectExplorer.Nodes);
            CurrentProject.ProjectTreeState = new Dictionary<string, bool>();
            for (var i = 0; i < nodes.Count; i++)
                CurrentProject.ProjectTreeState.Add(nodes[i].FullPath.Replace('\\', '_'), nodes[i].IsExpanded);
        }

        private void RestoreProjectTreeState()
        {
            var nodes = AllNodes(TProjectExplorer.Nodes);
            if (CurrentProject.ProjectTreeState == null) return;
            for (var i = 0; i < nodes.Count; i++)
            {
                if (!CurrentProject.ProjectTreeState.ContainsKey(nodes[i].FullPath.Replace('\\', '_'))) continue;
                if (CurrentProject.ProjectTreeState[nodes[i].FullPath.Replace('\\', '_')])
                    nodes[i].Expand();
                else
                    nodes[i].Collapse();
            }
        }

        private List<TreeNode> AllNodes(TreeNodeCollection nodeCollection)
        {
            var nodes = new List<TreeNode>();
            foreach (TreeNode node in nodeCollection)
            {
                nodes.Add(node);
                if (node.Nodes.Count > 0)
                    nodes.AddRange(AllNodes(node.Nodes));
            }
            return nodes;
        }

        private void TIDEForm_Load(object sender, EventArgs e)
        {
            //var editor = new FastColoredTextBox();
            
            //editor.TextChanged += new System.EventHandler<SynBoxNS.TextChangedEventArgs>(editor_TextChanged);
            //editor.KeyUp += new System.Windows.Forms.KeyEventHandler(editor_KeyUp);
            // 

        }

        private void TIDEForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private readonly FastColoredTextBoxNS.TextStyle _attributeStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(98, 214, 217)), null, FontStyle.Regular);
        private readonly FastColoredTextBoxNS.TextStyle _functionStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(92, 148, 180)), null, FontStyle.Regular | FontStyle.Bold);
        private readonly FastColoredTextBoxNS.TextStyle _objectStyle = new FastColoredTextBoxNS.TextStyle(new SolidBrush(Color.FromArgb(51, 190, 120)), null, FontStyle.Regular | FontStyle.Bold);
        private void TCodeEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle(TCodeEditor.SyntaxHighlighter.NumberStyle);
            e.ChangedRange.ClearStyle(_attributeStyle);
            e.ChangedRange.ClearStyle(_functionStyle);
            e.ChangedRange.ClearStyle(_objectStyle);

            e.ChangedRange.SetStyle(TCodeEditor.SyntaxHighlighter.NumberStyle, @"(?<range>[\-]?[\d+]([\.][\d+])?)", RegexOptions.Singleline | RegexOptions.Multiline);

            /*e.ChangedRange.ClearStyle(blueStyle);
            e.ChangedRange.SetStyle(blueStyle, @"(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?");*/

            //e.ChangedRange.SetStyle(_commentStyle, @"=?{", RegexOptions.Singleline);
            //e.ChangedRange.SetStyle(_functionStyle, @"([\(\s]+)?(?<range>[\w]+)([\)\s]+)?\.(?:\w+)", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            //e.ChangedRange.SetStyle(_attributeStyle, @"[^\?][\{\,\s]+(?<range>(?:""|')?[\s\w]+(?:""|')?)\s?\:", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            foreach (var found in TCodeEditor.GetRanges(@"(function)\s+(?<range>\w+)|(?<range>\w+)[\s+]?(\:|=)[\s+]?(function)", RegexOptions.Multiline | RegexOptions.IgnoreCase))
                TCodeEditor.Range.SetStyle(_functionStyle, @"\b" + found.Text + @"\b");

            foreach (var found in TCodeEditor.GetRanges(@"(?<range>\w+)[\s+]?(=|\:)[\s+]?{|(?<range>\w+)[\s+]?(=|\:)[\s+]?(new)\s\w+[^\.]|(?<range>\w+)[\s]?(=|\:)[\s]?(this)[^\.]", RegexOptions.Multiline | RegexOptions.IgnoreCase))
                TCodeEditor.Range.SetStyle(_objectStyle, @"\b" + found.Text + @"\b");

            //e.ChangedRange.SetStyle(BrownStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");
            //comment highlighting
            //e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            //e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            //e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            //number highlighting
            //e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
            //attribute highlighting
            //e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);
            //class name highlighting
            //e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b");
            //keyword highlighting
            //e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b");

            //clear folding markers
            //e.ChangedRange.ClearFoldingMarkers();

            //set folding markers
            //e.ChangedRange.SetFoldingMarkers("{", "}");//allow to collapse brackets block
            //e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");//allow to collapse #region blocks
            //e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");//allow to collapse comment block
        }

        private void TIDEForm_Resize(object sender, EventArgs e)
        {
            //TEditorWebControl.Size = new Size(TEditorWebControl.Size.Width, TEditorWebControl.Size.Height + 50);
            //TEditorWebControl.Refresh();
        }

        private bool TCodeEditor_IsNumber(Place place)
        {
            var mask = TCodeEditor.GetStyleIndexMask(new[] { TCodeEditor.SyntaxHighlighter.NumberStyle });
            if (place.iChar >= TCodeEditor.GetLineLength(place.iLine)) return false;
            return (TCodeEditor[place].style & mask) != 0;
        }



        private float _startNum;
        private Point _startMouseLocation = Point.Empty;
        private Place _valueChangePoint = Place.Empty;

        private void TCodeEditor_MouseMove(object sender, MouseEventArgs e)
        {
            TCodeEditor.Cursor = Cursors.IBeam;
            if (_valueChangePoint == Place.Empty) return;
            var range = TCodeEditor.GetRange(_valueChangePoint, _valueChangePoint);
            var numberFragment = range.GetFragment(TCodeEditor.SyntaxHighlighter.NumberStyle, false);
            var number = numberFragment.Text;
            if (number.Length <= 0) return;
            string nextNumber;
            var num = float.Parse(number, CultureInfo.InvariantCulture);
            if (Math.Round((decimal)_startNum, MidpointRounding.ToEven) == 0)
                _startNum = num;
            var modifier = (_startMouseLocation.Y - e.Location.Y);
            if (modifier > 0)
            {
                nextNumber = (_startNum + modifier).ToString(CultureInfo.InvariantCulture);
                TCodeEditor.Cursor = Cursors.PanNorth;
            }
            else
            {
                nextNumber = (_startNum + modifier).ToString(CultureInfo.InvariantCulture);
                TCodeEditor.Cursor = Cursors.PanSouth;
            }
            TCodeEditor.Selection = numberFragment;
            TCodeEditor.ClearSelected();
            var insertedRange = TCodeEditor.InsertText(nextNumber, TCodeEditor.SyntaxHighlighter.NumberStyle, true);
            _valueChangePoint = insertedRange.Start;
        }

        private void TCodeEditor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var p = TCodeEditor.PointToPlace(e.Location);
            if (!TCodeEditor_IsNumber(p)) return;
            _valueChangePoint = p;
            _startMouseLocation = e.Location;
            _startNum = 0;
        }

        private void TCodeEditor_MouseUp(object sender, MouseEventArgs e)
        {
            _valueChangePoint = Place.Empty;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void SwitchProjectContainer(bool state)
        {
            TIDEEditorContainer.Panel2Collapsed = state;
            TMainMenuToolboxButton.Checked = !TIDEEditorContainer.Panel2Collapsed;
        }

        private void SwitchProjectUtilsContainer(bool state)
        {
            TEditorContainerForm.Panel2Collapsed = state;
            TMainMenuUtilsButton.Checked = !TEditorContainerForm.Panel2Collapsed;
        }

        private void TMainMenuUtilsButton_Click(object sender, EventArgs e)
        {
            SwitchProjectUtilsContainer(!TEditorContainerForm.Panel2Collapsed);
        }

        private void TMainMenuToolboxButton_Click(object sender, EventArgs e)
        {
            SwitchProjectContainer(!TIDEEditorContainer.Panel2Collapsed);
        }

        private void TProjectExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TProperties.SelectedObject = (e.Node as TProjectTreeNode).PropObject;
        }

        private void TProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            ((IUpdateable)TProperties.SelectedObject).Update();
        }

        private void TProjectExplorer_AfterCollapse(object sender, TreeViewEventArgs e)
        {
        }

        private void TProjectExplorer_AfterExpand(object sender, TreeViewEventArgs e)
        {
        }

        private void TProjectMainMenuSave_Click(object sender, EventArgs e)
        {
            Save();
        }

    }
}
