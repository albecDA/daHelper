using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ExcelDna.Integration;
using ExcelDna.Logging;

namespace daHelper
{
    public partial class RegisterAddIn : IExcelAddIn
    {
        // AddInWatcher _watcher;
        public void AutoOpen()
        {
   /*         var configFileName = "AddInReloaderConfiguration.xml";
            var xllDirectory = Path.GetDirectoryName(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\..\\..\\..\\")));
            var configPath = Path.Combine(xllDirectory, configFileName);

            try
            {


                // Load config
                XmlSerializer configLoader = new XmlSerializer(typeof(AddInReloaderConfiguration));
                AddInReloaderConfiguration config = (AddInReloaderConfiguration)configLoader.Deserialize(File.OpenRead(configPath));
                _watcher = new AddInWatcher(config);
            }
            catch (Exception ex)
            {
                LogDisplay.WriteLine("AddInReloader - Error loading the configuration file: " + ex.ToString());
            }
            */

            ExcelDna.IntelliSense.IntelliSenseServer.Install();
        }
        public void AutoClose()
        {
            //_watcher.Dispose();

        }

    }
}
