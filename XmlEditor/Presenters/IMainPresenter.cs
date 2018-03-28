namespace XmlEditor.Presenters
{
    /// <summary>
    /// Represents the main logic of the program.
    /// </summary>
    public interface IMainPresenter
    {
        /// <summary>
        /// Stores changes made to the attributes data grid.
        /// </summary>
        void EditAttributes();

        /// <summary>
        /// Stores changes made to the content text box.
        /// </summary>
        void EditContent();

        /// <summary>
        /// Updates the attributes and content display based on the highlight of a node.
        /// </summary>
        void HighlightNode();

        /// <summary>
        /// Clears existing fields for a new file to be created.
        /// </summary>
        void New();

        /// <summary>
        /// Reads a file at a path and loads the user interface with the contents found.
        /// </summary>
        void ReadFile();

        /// <summary>
        /// Saves changes to an XML file.
        /// </summary>
        void SaveFile();

        /// <summary>
        /// Saves changes to an XML document at a new file path.
        /// </summary>
        void SaveAsFile();
    }
}
