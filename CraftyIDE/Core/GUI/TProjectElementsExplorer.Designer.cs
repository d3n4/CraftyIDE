namespace CraftyIDE.Core.GUI
{
    partial class TProjectElementsExplorer
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
            this.TThemeContainer = new Ambiance_ThemeContainer();
            this.TAddButton = new Ambiance_Button_2();
            this.TCancelButton = new Ambiance_Button_1();
            this.TElementsTree = new System.Windows.Forms.TreeView();
            this.TThemeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TThemeContainer
            // 
            this.TThemeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.TThemeContainer.Controls.Add(this.TAddButton);
            this.TThemeContainer.Controls.Add(this.TCancelButton);
            this.TThemeContainer.Controls.Add(this.TElementsTree);
            this.TThemeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TThemeContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TThemeContainer.Location = new System.Drawing.Point(0, 0);
            this.TThemeContainer.Name = "TThemeContainer";
            this.TThemeContainer.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.TThemeContainer.RoundCorners = true;
            this.TThemeContainer.Sizable = true;
            this.TThemeContainer.Size = new System.Drawing.Size(307, 364);
            this.TThemeContainer.SmartBounds = true;
            this.TThemeContainer.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TThemeContainer.TabIndex = 0;
            this.TThemeContainer.Text = "elements viewer";
            // 
            // TAddButton
            // 
            this.TAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TAddButton.BackColor = System.Drawing.Color.Transparent;
            this.TAddButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.TAddButton.Image = null;
            this.TAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TAddButton.Location = new System.Drawing.Point(22, 320);
            this.TAddButton.Name = "TAddButton";
            this.TAddButton.Size = new System.Drawing.Size(128, 32);
            this.TAddButton.TabIndex = 2;
            this.TAddButton.Text = "Add";
            this.TAddButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TAddButton.Click += new System.EventHandler(this.TAddButton_Click);
            // 
            // TCancelButton
            // 
            this.TCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TCancelButton.BackColor = System.Drawing.Color.Transparent;
            this.TCancelButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TCancelButton.Image = null;
            this.TCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TCancelButton.Location = new System.Drawing.Point(156, 320);
            this.TCancelButton.Name = "TCancelButton";
            this.TCancelButton.Size = new System.Drawing.Size(128, 32);
            this.TCancelButton.TabIndex = 1;
            this.TCancelButton.Text = "Cancel";
            this.TCancelButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TCancelButton.Click += new System.EventHandler(this.TCancelButton_Click);
            // 
            // TElementsTree
            // 
            this.TElementsTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TElementsTree.CheckBoxes = true;
            this.TElementsTree.Location = new System.Drawing.Point(23, 59);
            this.TElementsTree.Name = "TElementsTree";
            this.TElementsTree.ShowRootLines = false;
            this.TElementsTree.Size = new System.Drawing.Size(261, 255);
            this.TElementsTree.TabIndex = 0;
            // 
            // TProjectElementsExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 364);
            this.Controls.Add(this.TThemeContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "TProjectElementsExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "elements viewer";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.TProjectElementsExplorer_Load);
            this.TThemeContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance_ThemeContainer TThemeContainer;
        private Ambiance_Button_2 TAddButton;
        private Ambiance_Button_1 TCancelButton;
        public System.Windows.Forms.TreeView TElementsTree;
    }
}