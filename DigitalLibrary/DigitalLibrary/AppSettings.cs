using System.Xml.Serialization;

namespace DigitalLibrary
{
    public class AppSettingsXMLFile
    {
        public string DataSource { get; set; }
        public string DatabaseName { get; set; }
    }

    public class AppSettings
    {
        private XmlSerializer _XmlSerilizerDeserilizer;
        private string _FilePath;

        public AppSettings(string FilePath)
        {
            _FilePath = FilePath;
            _XmlSerilizerDeserilizer = new XmlSerializer(typeof(AppSettingsXMLFile));
        }

        public AppSettingsXMLFile LoadFromFile()
        {
            if (!File.Exists(_FilePath))
            {
                //CHANGE YOUR DATABASE_NAME AND DATA_SOURCE
                WriteToFile(new AppSettingsXMLFile() { DatabaseName = "DigitalLibrary", DataSource = "DESKTOP-QAQGGK3" });
            }

            System.IO.TextReader textReader = new System.IO.StreamReader(_FilePath);
            var AppSettingsXmlFileData = _XmlSerilizerDeserilizer.Deserialize(textReader) as AppSettingsXMLFile;
            textReader.Close();

            return AppSettingsXmlFileData;
        }

        public void WriteToFile(AppSettingsXMLFile SettingsFile)
        {
            System.IO.TextWriter textWriter = new System.IO.StreamWriter(_FilePath);
            _XmlSerilizerDeserilizer.Serialize(textWriter, SettingsFile);
            textWriter.Close();           
        }

        public string CreateConnectionStringFromLoadedFile(AppSettingsXMLFile appsettingsfile)
        {
            return $"Data Source={appsettingsfile.DataSource};Initial Catalog={appsettingsfile.DatabaseName};Integrated Security=True;TrustServerCertificate=True";
        }
    }

}
