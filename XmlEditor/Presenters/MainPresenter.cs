using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using XmlEditor.Models;
using XmlEditor.Views;

namespace XmlEditor.Presenters
{
    /// <summary>
    /// Implements the main logic of the program.
    /// </summary>
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainModel model;
        private readonly IMainView view;

        private string filePath;
        private Dictionary<string, Dictionary<string, string>> attributes = new Dictionary<string, Dictionary<string, string>>();
        private Dictionary<string, string> content = new Dictionary<string, string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPresenter"/> class with dependencies.
        /// </summary>
        /// <param name="model">An instance of the file operations model for the program.</param>
        /// <param name="view">An instance of the user interface for the program.</param>
        public MainPresenter(IMainModel model, IMainView view)
        {
            this.model = model;
            this.view = view;
            this.view.Presenter = this;
        }

        #region IMainPresenter members
        /// <summary>Implements <see cref="IMainPresenter.EditAttributes"/>.</summary>
        public void EditAttributes()
        {
            attributes[view.HighlightedNode] = view.Attributes;
        }

        /// <summary>Implements <see cref="IMainPresenter.EditContent"/>.</summary>
        public void EditContent()
        {
            content[view.HighlightedNode] = view.Content;
        }

        /// <summary>Implements <see cref="IMainPresenter.HighlightNode"/>.</summary>
        public void HighlightNode()
        {
            string name = view.HighlightedNode;
            view.Attributes = attributes[name];
            view.Content = content[name];
        }

        /// <summary>Implements <see cref="IMainPresenter.New"/>.</summary>
        public void New()
        {
            view.Nodes.Clear();
            attributes.Clear();
            filePath = null;
            view.FilePath = filePath;
            view.Content = string.Empty;
            view.Attributes = new Dictionary<string, string>();
        }

        /// <summary>Implements <see cref="IMainPresenter.ReadFile"/>.</summary>
        public void ReadFile()
        {
            view.Nodes.Clear();
            attributes.Clear();
            filePath = view.RequestedFilePath;
            view.FilePath = filePath;
            XDocument document = model.ReadXmlFile(filePath);
            XElement element = document.Elements().FirstOrDefault();
            ReadXml(element);
            view.SelectFirstNode();
        }

        /// <summary>Implements <see cref="IMainPresenter.SaveAsFile"/>.</summary>
        public void SaveAsFile()
        {
            SaveTheFile();
        }

        /// <summary>Implements <see cref="IMainPresenter.SaveFile"/>.</summary>
        public void SaveFile()
        {
            if (filePath == null)
            {
                view.SpecifySaveAs();
            }
            SaveTheFile();
        }
        #endregion

        private XElement ReadTree(TreeNode node)
        {
            XElement xElement = new XElement(node.Text);

            foreach (var attribute in attributes[node.Name])
                xElement.Add(new XAttribute(attribute.Key, attribute.Value));

            xElement.Value = content[node.Name];

            foreach (TreeNode childNode in node.Nodes)
                xElement.Add(ReadTree(childNode));

            return xElement;
        }

        private void ReadXml(XElement element, TreeNode treeNode = null)
        {
            TreeNodeCollection nodes = treeNode != null ? treeNode.Nodes : view.Nodes;
            string nodeKey = Guid.NewGuid().ToString("D");
            TreeNode childNode = nodes.Add(nodeKey, element.Name.LocalName);
            Dictionary<string, string> attributeDictionary = new Dictionary<string, string>();
            foreach (XAttribute attribute in element.Attributes())
            {
                attributeDictionary.Add(attribute.Name.LocalName, attribute.Value);
            }
            attributes.Add(nodeKey, attributeDictionary);

            string contentValue = element.Nodes().OfType<XText>().Aggregate(new StringBuilder(),
                          (s, c) => s.Append(c), s => s.ToString()).Trim();
            content.Add(nodeKey, contentValue);

            foreach (XElement childElement in element.Elements())
            {
                ReadXml(childElement, childNode);
            }
        }

        private void SaveTheFile()
        {
            filePath = view.RequestedFilePath;
            view.FilePath = filePath;
            XElement element = ReadTree(view.Nodes[0]);
            XDocument document = new XDocument(element);
            model.SaveXml(document, filePath);
        }
    }
}
