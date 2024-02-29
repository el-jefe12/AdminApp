using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HashishAdmin
{
    class DataHandler
    {
        public Admin admin;
        public List<User> userList = new List<User>();

        public User loggedInUser = null;

        public byte[] salt;
        Generation generation = new Generation();

        public DataHandler()
        {
            salt = generation.GenerateSalt();

            /*
            admin = new Admin("admin", generation.HashPassword("admin", salt), Convert.ToBase64String(salt));
            userList.Add(admin);
            */
            LoadFromXML();
        }

        public void SaveToXML()
        {
            XmlSerializer ser = new XmlSerializer(userList.GetType());
            string filePath = Path.Combine(Environment.CurrentDirectory, "kontakty.xml");

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                ser.Serialize(sw, userList);
            }
        }

        public bool LoadFromXML()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "kontakty.xml");

            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer ser = new XmlSerializer(userList.GetType());
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        userList = (List<User>)ser.Deserialize(sr);
                    }
                    return true;
                }
                catch (Exception)
                {
                    // Handle exceptions if needed
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
