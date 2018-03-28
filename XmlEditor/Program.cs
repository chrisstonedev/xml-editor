using System;
using System.Windows.Forms;
using XmlEditor.Models;
using XmlEditor.Presenters;
using XmlEditor.Views;

namespace XmlEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainModel model = new MainModel();
            IMainView view = new MainView();
            new MainPresenter(model, view);

            Application.Run(view as Form);
        }
    }
}
