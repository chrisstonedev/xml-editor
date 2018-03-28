using System.Xml.Linq;

namespace XmlEditor.Models
{
    /// <summary>
    /// Represents file operations for the program.
    /// </summary>
    public interface IMainModel
    {
        /// <summary>
        /// Loads an XML file located at a path an returns the contents of the file.
        /// </summary>
        /// <param name="filePath">The path to an XML file.</param>
        /// <returns>An XML document representing the contents as found on the file.</returns>
        XDocument ReadXmlFile(string filePath);

        /// <summary>
        /// Saves XML content to a file at a path.
        /// </summary>
        /// <param name="document">The XML document.</param>
        /// <param name="filePath">The path to the file to which to save the content.</param>
        void SaveXml(XDocument document, string filePath);
    }
}
