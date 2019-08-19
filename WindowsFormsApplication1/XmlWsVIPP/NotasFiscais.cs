using IntegradorWebService.XmlWsVIPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IntegradorWebService.XmlWsVIPP
{
    [XmlRoot(ElementName = "NotasFiscais")]
    public class NotasFiscais
    {
        [XmlElement(ElementName = "NotaFiscal")]
        public NotaFiscal NotaFiscal { get; set; }
    }
}
