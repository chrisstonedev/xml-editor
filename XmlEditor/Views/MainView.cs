using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XmlEditor.Presenters;

namespace XmlEditor.Views
{
    /// <summary>
    /// Implements the user interface of the program.
    /// </summary>
    public partial class MainView : Form, IMainView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainView"/> class.
        /// </summary>
        public MainView()
        {
            InitializeComponent();
        }

        #region IMainView members
        /// <summary>Implements <see cref="IMainView.Attributes"/>.</summary>
        public Dictionary<string, string> Attributes
        {
            get
            {
                Dictionary<string, string> attributes = new Dictionary<string, string>();
                foreach (DataGridViewRow dataRow in dataGridView.Rows)
                    if (dataRow.Cells[0].Value != null)
                        attributes.Add(dataRow.Cells[0].Value.ToString(), dataRow.Cells[1].Value.ToString());

                return attributes;
            }
            set
            {
                dataGridView.Rows.Clear();
                foreach (KeyValuePair<string, string> item in value)
                    dataGridView.Rows.Add(new object[] { item.Key, item.Value });
            }
        }

        /// <summary>Implements <see cref="IMainView.Content"/>.</summary>
        public string Content
        {
            get => contentsTextBox.Text;
            set => contentsTextBox.Text = value;
        }

        /// <summary>Implements <see cref="IMainView.FilePath"/>.</summary>
        public string FilePath { set => filePathTextBox.Text = value; }

        /// <summary>Implements <see cref="IMainView.HighlightedNode"/>.</summary>
        public string HighlightedNode { get; private set; }

        /// <summary>Implements <see cref="IMainView.Nodes"/>.</summary>
        public TreeNodeCollection Nodes => treeView.Nodes;

        /// <summary>Implements <see cref="IMainView.Presenter"/>.</summary>
        public IMainPresenter Presenter { private get; set; }

        /// <summary>Implements <see cref="IMainView.RequestedFilePath"/>.</summary>
        public string RequestedFilePath { get; private set; }

        /// <summary>Implements <see cref="IMainView.SelectFirstNode"/>.</summary>
        public void SelectFirstNode()
        {
            treeView.Select();
        }

        /// <summary>Implements <see cref="IMainView.SpecifySaveAs"/>.</summary>
        public void SpecifySaveAs()
        {
            SaveAs();
        }
        #endregion

        #region Control events
        private void ContentsTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Presenter.EditContent();
        }

        private void DataGridView_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Presenter.EditAttributes();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.New();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.SaveFile();
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            HighlightedNode = e.Node.Name;
            Presenter.HighlightNode();
        }
        #endregion

        private void OpenFile()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                var test = dialog.ShowDialog();
                if (test == DialogResult.OK)
                {
                    RequestedFilePath = dialog.FileName;
                    Presenter.ReadFile();
                }
            }
        }

        private void SaveAs()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                var test = dialog.ShowDialog();
                if (test == DialogResult.OK)
                {
                    RequestedFilePath = dialog.FileName;
                    Presenter.SaveAsFile();
                }
            }
        }
    }
}
