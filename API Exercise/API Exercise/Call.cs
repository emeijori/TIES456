using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API_Exercise
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("response")]
    public class Call
    {
        [System.Xml.Serialization.XmlElementAttribute("user_info")]
        public Fetch user { get; set; } 
    }
}
