using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using WindowsFormsApplication1.WSVIPP;

namespace WindowsFormsApplication1.Entities
{
    [XmlRoot(ElementName = "ItemConteudo", Namespace = "http://www.visualset.inf.br/")]
    public class ItemConteudo
    {
 
        [XmlElement(ElementName = "DescricaoConteudo", Namespace = "http://www.visualset.inf.br/")]
        public string descricaoConteudoField { get; set; }
        [XmlElement(ElementName = "Quantidade", Namespace = "http://www.visualset.inf.br/")]
        public int quantidadeField { get; set; }
        [XmlElement(ElementName = "Valor", Namespace = "http://www.visualset.inf.br/")]
        public string valorField { get; set; }

        public ItemConteudo(string descricaoConteudo)
        {
            descricaoConteudoField = descricaoConteudo;
        }
    }
}

