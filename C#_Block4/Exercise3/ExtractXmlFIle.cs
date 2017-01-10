using System;
using System.IO;
using System.Xml;
using System.Text;

namespace Exercise3
{
    public class ExtractXmlFIle
    {
        public string ReadXMLFile(string pathFile)
        {
            CheckFileXML(pathFile); //check xml file

            try
            {
                StreamReader reader = new StreamReader(pathFile);
                string textFile = reader.ReadToEnd();
                reader.Close();
                return DecodeFile(textFile);
            }
            catch(Exception)
            {
                throw new Exception("that file not exist.");
            }
        }

        private string DecodeFile(string textFile)
        {
            StringBuilder Text = new StringBuilder();

            XmlReader xmlFile = XmlReader.Create(new StringReader(textFile));
            while (xmlFile.Read())
            {
                switch (xmlFile.NodeType)
                {
                    case XmlNodeType.Text:
                        Text.Append(xmlFile.Value).AppendLine();
                        break;
                }
            }

            return Text.ToString();

        }

        //this method check if the file is or is not xml file
        private void CheckFileXML(string nameFile)
        {
            StringBuilder check = new StringBuilder();

            for(int i = 4; i > 0; i--)
            {
                check.Append(nameFile[nameFile.Length - i]);
            }

            if(check.ToString() == ".xml")
            {
                return;
            }
            else
            {
                throw new Exception("That file is not a XML file.");
            }
        }
    }
}
