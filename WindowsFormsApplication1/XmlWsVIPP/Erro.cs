using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IntegradorWebService.XmlWsVIPP
{
    [XmlRoot(ElementName = "Erro")]
    public class Erro
    {
        [XmlElement(ElementName = "TipoErro")]
        public string TipoErro { get; set; }
        [XmlElement(ElementName = "Atributo")]
        public string Atributo { get; set; }
        [XmlElement(ElementName = "Descricao")]
        public string Descricao { get; set; }
        [XmlElement(ElementName = "Mensagem")]
        public string Mensagem { get; set; }
        [XmlElement(ElementName = "StackTrace")]
        public string StackTrace { get; set; }
        [XmlElement(ElementName = "StackTraceOut")]
        public string StackTraceOut { get; set; }
        [XmlElement(ElementName = "Origem")]
        public string Origem { get; set; }
    }
}
