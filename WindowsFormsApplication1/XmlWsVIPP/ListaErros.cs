using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IntegradorWebService.XmlWsVIPP
{
    [XmlRoot(ElementName = "ListaErros")]
    public class ListaErros
    {
        [XmlElement(ElementName = "Erro")]
        public List<Erro> Erro { get; set; }
    }


}
