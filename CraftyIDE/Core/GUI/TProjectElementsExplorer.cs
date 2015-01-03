using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CraftyIDE.Core.Project;

namespace CraftyIDE.Core.GUI
{
    public partial class TProjectElementsExplorer : Form
    {
        public TProjectElementsExplorer()
        {
            InitializeComponent();
        }

        private void TProjectElementsExplorer_Load(object sender, EventArgs e)
        {
        }

        public TList<T> ShowDialog<T>(string caption, TList<T> items, bool autoSelect = true)  where T : class, IProjectItem
        {
            TElementsTree.Nodes.Clear();
            for (var index = 0; index < items.Count; index++)
            {
                var item = items[index];
                if (!item.Hidden)
                    TElementsTree.Nodes.Add(new TProjectTreeNode()
                    {
                        Name = item.Identifier + index,
                        Text = item.Identifier,
                        Checked = item.Included,
                        PropObject = item
                    });
            }
            TElementsTree.SelectedNode = null;
            Text = caption;
            TThemeContainer.Text = caption;
            ShowDialog();
            if (DialogResult != DialogResult.OK) return null;
            var elements = new TList<T>();
            elements.AddRange(from TProjectTreeNode element in TElementsTree.Nodes select (T) element.PropObject);
            if (!autoSelect) return elements;
            foreach (TProjectTreeNode node in TElementsTree.Nodes)
                ((IProjectItem)node.PropObject).Included = node.Checked;
            return elements;
        }

        private void TAddButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void TCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }
    }
}
