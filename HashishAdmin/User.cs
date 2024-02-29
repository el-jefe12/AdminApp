using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HashishAdmin
{
    [XmlInclude(typeof(Admin))]
    [XmlInclude(typeof(GenericUser))]
    public class User
    {
        public enum UserRole
        {
            None,
            GenericUser,
            Admin
        }

        public UserRole Role;

        public string Name { get; set; }
        public string Password { get; set; }

        //[XmlElement(DataType = "base64Binary")]
        public string Salt { get; set; }

        // Parameterless constructor for serialization
        public User()
        {

        }

        public User(string name, string password, string salt)
        {
            Name = name;
            Password = password;
            Salt = salt;
        }
    }

    public class Admin : User
    {
        // Parameterless constructor for serialization
        public Admin() : base()
        {
        }

        public Admin(string name, string password, string salt) : base(name, password, salt)
        {

        }
    }

    public class GenericUser : User
    {
        // Parameterless constructor for serialization
        public GenericUser() : base()
        {
        }

        public GenericUser(string name, string password, string salt) : base(name, password, salt)
        {

        }
    }
}
