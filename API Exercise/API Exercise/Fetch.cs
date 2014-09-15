using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API_Exercise
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("user_info")]
    public class Fetch
    {
        [System.Xml.Serialization.XmlElementAttribute("birth_date")]
        public string birthDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("display_name")]
        public string displayName { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("email")]
        public string sPosti { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("first_name")]
        public string firstName { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("gender")]
        public string gender { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("last_name")]
        public string lastName { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("location")]
        public string location { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("premium")]
        public string premium { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("website")]
        public string website { get; set; }
    }
}
