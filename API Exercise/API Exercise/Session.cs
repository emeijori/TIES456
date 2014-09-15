using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API_Exercise
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("response")]
    public class Session
    {
        [System.Xml.Serialization.XmlElementAttribute("session_token")]
        public string token { get; set; }
    }
}
