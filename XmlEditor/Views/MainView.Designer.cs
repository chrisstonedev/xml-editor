namespace XmlEditor.Views
{
    /// <summary>
    /// Implements the user interface of the program.
    /// </summary>
    partial class MainView
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
            this.filePathPanel = new System.Windows.Forms.Panel();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.valuesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.contentsTextBox = new System.Windows.Forms.TextBox();
            this.contentsLabelPanel = new System.Windows.Forms.Panel();
            this.contentsLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.attributeKeyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributesLabelPanel = new System.Windows.Forms.Panel();
            this.attributesLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valuesSplitContainer)).BeginInit();
            this.valuesSplitContainer.Panel1.SuspendLayout();
            this.valuesSplitContainer.Panel2.SuspendLayout();
            this.valuesSplitContainer.SuspendLayout();
            this.contentsLabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.attributesLabelPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePathPanel
            // 
            this.filePathPanel.Controls.Add(this.filePathTextBox);
            this.filePathPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePathPanel.Location = new System.Drawing.Point(0, 24);
            this.filePathPanel.Name = "filePathPanel";
            this.filePathPanel.Size = new System.Drawing.Size(800, 33);
            this.filePathPanel.TabIndex = 1;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(12, 7);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(498, 20);
            this.filePathTextBox.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainSplitContainer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 57);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 393);
            this.mainPanel.TabIndex = 3;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.valuesSplitContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(800, 393);
            this.mainSplitContainer.SplitterDistance = 266;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(266, 393);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // valuesSplitContainer
            // 
            this.valuesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.valuesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.valuesSplitContainer.Name = "valuesSplitContainer";
            this.valuesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // valuesSplitContainer.Panel1
            // 
            this.valuesSplitContainer.Panel1.Controls.Add(this.contentsTextBox);
            this.valuesSplitContainer.Panel1.Controls.Add(this.contentsLabelPanel);
            // 
            // valuesSplitContainer.Panel2
            // 
            this.valuesSplitContainer.Panel2.Controls.Add(this.dataGridView);
            this.valuesSplitContainer.Panel2.Controls.Add(this.attributesLabelPanel);
            this.valuesSplitContainer.Size = new System.Drawing.Size(530, 393);
            this.valuesSplitContainer.SplitterDistance = 114;
            this.valuesSplitContainer.TabIndex = 0;
            // 
            // contentsTextBox
            // 
            this.contentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentsTextBox.Location = new System.Drawing.Point(0, 24);
            this.contentsTextBox.Multiline = true;
            this.contentsTextBox.Name = "contentsTextBox";
            this.contentsTextBox.Size = new System.Drawing.Size(530, 90);
            this.contentsTextBox.TabIndex = 4;
            this.contentsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ContentsTextBox_Validating);
            // 
            // contentsLabelPanel
            // 
            this.contentsLabelPanel.Controls.Add(this.contentsLabel);
            this.contentsLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentsLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.contentsLabelPanel.Name = "contentsLabelPanel";
            this.contentsLabelPanel.Size = new System.Drawing.Size(530, 24);
            this.contentsLabelPanel.TabIndex = 3;
            // 
            // contentsLabel
            // 
            this.contentsLabel.AutoSize = true;
            this.contentsLabel.Location = new System.Drawing.Point(3, 0);
            this.contentsLabel.Name = "contentsLabel";
            this.contentsLabel.Size = new System.Drawing.Size(49, 13);
            this.contentsLabel.TabIndex = 2;
            this.contentsLabel.Text = "Contents";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attributeKeyColumn,
            this.attributeValueColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 26);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(530, 249);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.Validating += new System.ComponentModel.CancelEventHandler(this.DataGridView_Validating);
            // 
            // attributeKeyColumn
            // 
            this.attributeKeyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.attributeKeyColumn.HeaderText = "Attribute key";
            this.attributeKeyColumn.Name = "attributeKeyColumn";
            this.attributeKeyColumn.Width = 91;
            // 
            // attributeValueColumn
            // 
            this.attributeValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attributeValueColumn.HeaderText = "Attribute value";
            this.attributeValueColumn.Name = "attributeValueColumn";
            // 
            // attributesLabelPanel
            // 
            this.attributesLabelPanel.Controls.Add(this.attributesLabel);
            this.attributesLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.attributesLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.attributesLabelPanel.Name = "attributesLabelPanel";
            this.attributesLabelPanel.Size = new System.Drawing.Size(530, 26);
            this.attributesLabelPanel.TabIndex = 2;
            // 
            // attributesLabel
            // 
            this.attributesLabel.AutoSize = true;
            this.attributesLabel.Location = new System.Drawing.Point(3, 3);
            this.attributesLabel.Name = "attributesLabel";
            this.attributesLabel.Size = new System.Drawing.Size(51, 13);
            this.attributesLabel.TabIndex = 1;
            this.attributesLabel.Text = "Attributes";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.filePathPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainView";
            this.Text = "Form1";
            this.filePathPanel.ResumeLayout(false);
            this.filePathPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.valuesSplitContainer.Panel1.ResumeLayout(false);
            this.valuesSplitContainer.Panel1.PerformLayout();
            this.valuesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valuesSplitContainer)).EndInit();
            this.valuesSplitContainer.ResumeLayout(false);
            this.contentsLabelPanel.ResumeLayout(false);
            this.contentsLabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.attributesLabelPanel.ResumeLayout(false);
            this.attributesLabelPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel contentsLabelPanel;
        private System.Windows.Forms.TextBox contentsTextBox;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeKeyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeValueColumn;
        private System.Windows.Forms.Panel filePathPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer valuesSplitContainer;
        private System.Windows.Forms.Label contentsLabel;
        private System.Windows.Forms.Panel attributesLabelPanel;
        private System.Windows.Forms.Label attributesLabel;
    }
}

