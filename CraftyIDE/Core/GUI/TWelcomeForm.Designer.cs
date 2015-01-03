namespace CraftyIDE.Core.GUI
{
    partial class TWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TWelcomeForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("New Project", 0, 0);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Import Project", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("MyProject", 1, 1);
            this.TProjectImages = new System.Windows.Forms.ImageList(this.components);
            this.ambiance_ThemeContainer1 = new Ambiance_ThemeContainer();
            this.TProjectNameInput = new System.Windows.Forms.TextBox();
            this.TCreateButton = new Ambiance_Button_2();
            this.TErrorLabel = new Ambiance_HeaderLabel();
            this.ambiance_HeaderLabel2 = new Ambiance_HeaderLabel();
            this.TProjectList = new System.Windows.Forms.TreeView();
            this.TRecentProjectList = new System.Windows.Forms.TreeView();
            this.ambiance_HeaderLabel1 = new Ambiance_HeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ambiance_ControlBox1 = new Ambiance_ControlBox();
            this.ambiance_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TProjectImages
            // 
            this.TProjectImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TProjectImages.ImageStream")));
            this.TProjectImages.TransparentColor = System.Drawing.Color.Transparent;
            this.TProjectImages.Images.SetKeyName(0, "blue-document.png");
            this.TProjectImages.Images.SetKeyName(1, "blue-folder-horizontal.png");
            // 
            // ambiance_ThemeContainer1
            // 
            this.ambiance_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambiance_ThemeContainer1.Controls.Add(this.TProjectNameInput);
            this.ambiance_ThemeContainer1.Controls.Add(this.TCreateButton);
            this.ambiance_ThemeContainer1.Controls.Add(this.TErrorLabel);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_HeaderLabel2);
            this.ambiance_ThemeContainer1.Controls.Add(this.TProjectList);
            this.ambiance_ThemeContainer1.Controls.Add(this.TRecentProjectList);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_HeaderLabel1);
            this.ambiance_ThemeContainer1.Controls.Add(this.pictureBox1);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_ControlBox1);
            this.ambiance_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambiance_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambiance_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ambiance_ThemeContainer1.Name = "ambiance_ThemeContainer1";
            this.ambiance_ThemeContainer1.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambiance_ThemeContainer1.RoundCorners = true;
            this.ambiance_ThemeContainer1.Sizable = false;
            this.ambiance_ThemeContainer1.Size = new System.Drawing.Size(508, 349);
            this.ambiance_ThemeContainer1.SmartBounds = true;
            this.ambiance_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ambiance_ThemeContainer1.TabIndex = 0;
            // 
            // TProjectNameInput
            // 
            this.TProjectNameInput.Location = new System.Drawing.Point(23, 306);
            this.TProjectNameInput.Name = "TProjectNameInput";
            this.TProjectNameInput.Size = new System.Drawing.Size(335, 23);
            this.TProjectNameInput.TabIndex = 14;
            this.TProjectNameInput.Text = "New Project";
            // 
            // TCreateButton
            // 
            this.TCreateButton.BackColor = System.Drawing.Color.Transparent;
            this.TCreateButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.TCreateButton.Image = null;
            this.TCreateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TCreateButton.Location = new System.Drawing.Point(364, 303);
            this.TCreateButton.Name = "TCreateButton";
            this.TCreateButton.Size = new System.Drawing.Size(121, 27);
            this.TCreateButton.TabIndex = 13;
            this.TCreateButton.Text = "Create";
            this.TCreateButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TCreateButton.Click += new System.EventHandler(this.TCreateButton_Click);
            // 
            // TErrorLabel
            // 
            this.TErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.TErrorLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.TErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TErrorLabel.Image = global::CraftyIDE.Properties.Resources.minus_circle;
            this.TErrorLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TErrorLabel.Location = new System.Drawing.Point(23, 334);
            this.TErrorLabel.Name = "TErrorLabel";
            this.TErrorLabel.Size = new System.Drawing.Size(462, 20);
            this.TErrorLabel.TabIndex = 11;
            this.TErrorLabel.Text = "     ERROR";
            this.TErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TErrorLabel.Visible = false;
            // 
            // ambiance_HeaderLabel2
            // 
            this.ambiance_HeaderLabel2.AutoSize = true;
            this.ambiance_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel2.Location = new System.Drawing.Point(33, 56);
            this.ambiance_HeaderLabel2.Name = "ambiance_HeaderLabel2";
            this.ambiance_HeaderLabel2.Size = new System.Drawing.Size(107, 20);
            this.ambiance_HeaderLabel2.TabIndex = 11;
            this.ambiance_HeaderLabel2.Text = "Create project";
            // 
            // TProjectList
            // 
            this.TProjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.TProjectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TProjectList.FullRowSelect = true;
            this.TProjectList.ImageIndex = 0;
            this.TProjectList.ImageList = this.TProjectImages;
            this.TProjectList.ItemHeight = 32;
            this.TProjectList.Location = new System.Drawing.Point(23, 79);
            this.TProjectList.Name = "TProjectList";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "NewProjectNode";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Tag = "new";
            treeNode1.Text = "New Project";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "OpenProjectNode";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Tag = "import";
            treeNode2.Text = "Import Project";
            this.TProjectList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.TProjectList.SelectedImageIndex = 0;
            this.TProjectList.ShowLines = false;
            this.TProjectList.ShowPlusMinus = false;
            this.TProjectList.ShowRootLines = false;
            this.TProjectList.Size = new System.Drawing.Size(227, 218);
            this.TProjectList.TabIndex = 10;
            this.TProjectList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TProjectList_NodeMouseDoubleClick);
            // 
            // TRecentProjectList
            // 
            this.TRecentProjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.TRecentProjectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TRecentProjectList.FullRowSelect = true;
            this.TRecentProjectList.ImageIndex = 1;
            this.TRecentProjectList.ImageList = this.TProjectImages;
            this.TRecentProjectList.ItemHeight = 32;
            this.TRecentProjectList.Location = new System.Drawing.Point(258, 79);
            this.TRecentProjectList.Name = "TRecentProjectList";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Node0";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "MyProject";
            this.TRecentProjectList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.TRecentProjectList.SelectedImageIndex = 0;
            this.TRecentProjectList.ShowLines = false;
            this.TRecentProjectList.ShowPlusMinus = false;
            this.TRecentProjectList.ShowRootLines = false;
            this.TRecentProjectList.Size = new System.Drawing.Size(227, 218);
            this.TRecentProjectList.TabIndex = 10;
            this.TRecentProjectList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TRecentProjectList_NodeMouseDoubleClick);
            // 
            // ambiance_HeaderLabel1
            // 
            this.ambiance_HeaderLabel1.AutoSize = true;
            this.ambiance_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ambiance_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_HeaderLabel1.Location = new System.Drawing.Point(265, 56);
            this.ambiance_HeaderLabel1.Name = "ambiance_HeaderLabel1";
            this.ambiance_HeaderLabel1.Size = new System.Drawing.Size(117, 20);
            this.ambiance_HeaderLabel1.TabIndex = 9;
            this.ambiance_HeaderLabel1.Text = "Recent projects";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ambiance_ControlBox1
            // 
            this.ambiance_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_ControlBox1.EnableMaximize = false;
            this.ambiance_ControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.ambiance_ControlBox1.Location = new System.Drawing.Point(5, 13);
            this.ambiance_ControlBox1.Name = "ambiance_ControlBox1";
            this.ambiance_ControlBox1.Size = new System.Drawing.Size(44, 22);
            this.ambiance_ControlBox1.TabIndex = 0;
            this.ambiance_ControlBox1.Text = "ambiance_ControlBox1";
            // 
            // TWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(508, 349);
            this.Controls.Add(this.ambiance_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "TWelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TWelcomeForm_FormClosing);
            this.Load += new System.EventHandler(this.TWelcomeForm_Load);
            this.Shown += new System.EventHandler(this.TWelcomeForm_Shown);
            this.ambiance_ThemeContainer1.ResumeLayout(false);
            this.ambiance_ThemeContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance_ThemeContainer ambiance_ThemeContainer1;
        private Ambiance_ControlBox ambiance_ControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Ambiance_HeaderLabel ambiance_HeaderLabel1;
        private System.Windows.Forms.TreeView TRecentProjectList;
        private System.Windows.Forms.ImageList TProjectImages;
        private System.Windows.Forms.TreeView TProjectList;
        private Ambiance_HeaderLabel ambiance_HeaderLabel2;
        private Ambiance_Button_2 TCreateButton;
        private Ambiance_HeaderLabel TErrorLabel;
        private System.Windows.Forms.TextBox TProjectNameInput;
    }
}