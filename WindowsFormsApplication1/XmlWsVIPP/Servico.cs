using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IntegradorWebService.XmlWsVIPP
{

    [XmlRoot(ElementName = "Servico")]
    public class Servico
    {
        [XmlElement(ElementName = "ServicoECT")]
        public string ServicoECT { get; set; }
    }
}
