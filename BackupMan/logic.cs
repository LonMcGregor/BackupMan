using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BackupMan
{
    class logic
    {

        private XmlNodeList myBackups;

        public logic()
        {
            myBackups = null;
        }
        public logic(String xmlData)
        {
            loadXMLDoc(xmlData);
        }

        public int count()
        {
            return myBackups.Count;
        }

        private void loadXMLDoc(String loc){
            XmlDocument xdoc = new XmlDocument();
            try
            {
                xdoc.Load(loc);
            }
            catch (XmlException e)
            {
                throw new InvalidDataFile(e.Message);
            }
            myBackups = xdoc.GetElementsByTagName("backupObj");
            if (myBackups.Count==0)
                throw new InvalidDataFile("Error reading data file. Check that it is not empty and is in right format");
        }

        /* makes call to 7zip to make backup*/
        public void doBackup(String dirFrom, String dirTo)
        {
            string strCmdText = "/C 7z a -t7z \"" + dirTo + "\" \"" + dirFrom ;
            System.Diagnostics.Process.Start("cmd.exe", strCmdText);
        }

        /* return all location names registered to back up from*/
        public String[] getLocationNames()
        {
            String[] s = new String[myBackups.Count];
            for (int i = 0; i < myBackups.Count; i++){
                s[i] = myBackups.Item(i).ChildNodes.Item(0).InnerText;
            }
            return s;
        }

        /* return all locations registered */
        public String[] getFromLocations()
        {
            String[] s = new String[myBackups.Count];
            for (int i = 0; i < myBackups.Count; i++)
            {
                s[i] = myBackups.Item(i).ChildNodes.Item(1).InnerText;
            }
            return s;
        }

        /* return output names*/
        public String[] getToLocations()
        {
            String[] s = new String[myBackups.Count];
            for (int i = 0; i < myBackups.Count; i++)
            {
                s[i] = myBackups.Item(i).ChildNodes.Item(2).InnerText;
            }
            return s;
        }


        [Serializable]
        public class InvalidDataFile : Exception
        {
            public InvalidDataFile() { }
            public InvalidDataFile(string message) : base(message) { }
            public InvalidDataFile(string message, Exception inner) : base(message, inner) { }
            protected InvalidDataFile(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context)
                : base(info, context) { }
        }

    }
}
