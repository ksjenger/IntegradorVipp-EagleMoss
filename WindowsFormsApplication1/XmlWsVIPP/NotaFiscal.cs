using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IntegradorWebService.XmlWsVIPP
{
    [XmlRoot(ElementName = "NotaFiscal")]
    public class NotaFiscal
    {
        [XmlElement(ElementName = "DtNotaFiscal")]
        public string DtNotaFiscal { get; set; }
        [XmlElement(ElementName = "SerieNotaFiscal")]
        public string SerieNotaFiscal { get; set; }
        [XmlElement(ElementName = "NrNotaFiscal")]
        public string NrNotaFiscal { get; set; }
        [XmlElement(ElementName = "VlrTotalNota")]
        public string VlrTotalNota { get; set; }
    }
}
