using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace IntegradorWebService
{
    [XmlRoot(ElementName = "ContratoEct")]
    public class ContratoEct
    {
        [XmlElement(ElementName = "NrContrato")]
        public string NrContrato { get; set; }
        [XmlElement(ElementName = "CodigoAdministrativo")]
        public string CodigoAdministrativo { get; set; }
        [XmlElement(ElementName = "NrCartao")]
        public string NrCartao { get; set; }
    }
}