using System.Xml.Linq;

namespace XmlEditor.Models
{
    /// <summary>
    /// Implements file operations for the program.
    /// </summary>
    public class MainModel : IMainModel
    {
        /// <summary>Implements <see cref="IMainModel.ReadXmlFile(string)"/>.</summary>
        public XDocument ReadXmlFile(string filePath)
        {
            return XDocument.Load(filePath);
        }

        /// <summary>Implements <see cref="IMainModel.SaveXml(XDocument, string)"/>.</summary>
        public void SaveXml(XDocument document, string filePath)
        {
            document.Save(filePath);
        }
    }
}
