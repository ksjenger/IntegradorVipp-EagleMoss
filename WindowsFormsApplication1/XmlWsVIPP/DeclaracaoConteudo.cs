using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IntegradorWebService.XmlWsVIPP
{
    [XmlRoot(ElementName = "DeclaracaoConteudo", Namespace = "http://www.visualset.inf.br/")]
    public class DeclaracaoConteudo
    {
        [XmlElement(ElementName = "DocumentoRemetente", Namespace = "http://www.visualset.inf.br/")]
        public string DocumentoRemetente { get; set; }
        [XmlElement(ElementName = "DocumentoDestinatario", Namespace = "http://www.visualset.inf.br/")]
        public string DocumentoDestinatario { get; set; }
        [XmlElement(ElementName = "PesoTotal", Namespace = "http://www.visualset.inf.br/")]
        public string PesoTotal { get; set; }
        [XmlElement(ElementName = "ItemConteudo", Namespace = "http://www.visualset.inf.br/")]
        public ItemConteudo[] ItemConteudo { get; set; }

        public DeclaracaoConteudo(ItemConteudo[] itemConteudo)
        {
            ItemConteudo = itemConteudo;
        }

        public DeclaracaoConteudo()
        {
        }
    }

}
