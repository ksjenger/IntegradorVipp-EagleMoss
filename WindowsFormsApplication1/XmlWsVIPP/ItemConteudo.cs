using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IntegradorWebService.XmlWsVIPP
{
    [XmlRoot(ElementName = "ItemConteudo", Namespace = "http://www.visualset.inf.br/")]
    public class ItemConteudo
    {
        [XmlElement(ElementName = "DescricaoConteudo", Namespace = "http://www.visualset.inf.br/")]
        public string DescricaoConteudo { get; set; }

        [XmlElement(ElementName = "Quantidade", Namespace = "http://www.visualset.inf.br/")]
        public string Quantidade { get; set; }
        [XmlElement(ElementName = "Valor", Namespace = "http://www.visualset.inf.br/")]
        public string Valor { get; set; }

        public ItemConteudo(string descricaoConteudo)
        {
            DescricaoConteudo = descricaoConteudo;
        }

        public ItemConteudo()
        {
        }
    }
}
