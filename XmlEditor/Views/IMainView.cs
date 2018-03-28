using System.Collections.Generic;
using System.Windows.Forms;
using XmlEditor.Presenters;

namespace XmlEditor.Views
{
    /// <summary>
    /// Represents the user interface of the program.
    /// </summary>
    public interface IMainView
    {
        /// <summary>
        /// Gets or sets the attribute keys and values for a node.
        /// </summary>
        Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or sets the text content in a node.
        /// </summary>
        string Content { get; set; }

        /// <summary>
        /// Sets the file path to display to the user.
        /// </summary>
        string FilePath { set; }

        /// <summary>
        /// Gets the key of the node most recently highlighted.
        /// </summary>
        string HighlightedNode { get; }

        /// <summary>
        /// Gets a collection of tree nodes.
        /// </summary>
        TreeNodeCollection Nodes { get; }

        /// <summary>
        /// Sets an instance of the main logic of the program.
        /// </summary>
        IMainPresenter Presenter { set; }

        /// <summary>
        /// Gets the file path requested by the user to use for an operation.
        /// </summary>
        string RequestedFilePath { get; }

        /// <summary>
        /// Selects the first node as found after loading.
        /// </summary>
        void SelectFirstNode();

        /// <summary>
        /// Asks the user for a file path to save changes as.
        /// </summary>
        void SpecifySaveAs();
    }
}
