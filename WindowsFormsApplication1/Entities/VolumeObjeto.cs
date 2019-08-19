using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WindowsFormsApplication1.Entities
{

    [XmlRoot(ElementName = "VolumeObjeto", Namespace = "http://www.visualset.inf.br/")]
    public class VolumeObjeto
    {
        [XmlElement(ElementName = "Peso", Namespace = "http://www.visualset.inf.br/")]
        public string Peso { get; set; }
        [XmlElement(ElementName = "Altura", Namespace = "http://www.visualset.inf.br/")]
        public string Altura { get; set; }
        [XmlElement(ElementName = "Largura", Namespace = "http://www.visualset.inf.br/")]
        public string Largura { get; set; }
        [XmlElement(ElementName = "Comprimento", Namespace = "http://www.visualset.inf.br/")]
        public string Comprimento { get; set; }
        [XmlElement(ElementName = "ContaLote", Namespace = "http://www.visualset.inf.br/")]
        public string ContaLote { get; set; }
        [XmlElement(ElementName = "ChaveRoteamento", Namespace = "http://www.visualset.inf.br/")]
        public string ChaveRoteamento { get; set; }
        [XmlElement(ElementName = "CodigoBarraVolume", Namespace = "http://www.visualset.inf.br/")]
        public string CodigoBarraVolume { get; set; }
        [XmlElement(ElementName = "CodigoBarraCliente", Namespace = "http://www.visualset.inf.br/")]
        public string CodigoBarraCliente { get; set; }
        [XmlElement(ElementName = "ObservacaoVisual", Namespace = "http://www.visualset.inf.br/")]
        public string ObservacaoVisual { get; set; }
        [XmlElement(ElementName = "ObservacaoQuatro", Namespace = "http://www.visualset.inf.br/")]
        public string ObservacaoQuatro { get; set; }
        [XmlElement(ElementName = "ObservacaoCinco", Namespace = "http://www.visualset.inf.br/")]
        public string ObservacaoCinco { get; set; }
        [XmlElement(ElementName = "PosicaoVolume", Namespace = "http://www.visualset.inf.br/")]
        public string PosicaoVolume { get; set; }
        [XmlElement(ElementName = "Conteudo", Namespace = "http://www.visualset.inf.br/")]
        public string Conteudo { get; set; }
        [XmlElement(ElementName = "DeclaracaoConteudo", Namespace = "http://www.visualset.inf.br/")]
        public DeclaracaoConteudo DeclaracaoConteudo { get; set; }
        [XmlElement(ElementName = "ValorDeclarado", Namespace = "http://www.visualset.inf.br/")]
        public string ValorDeclarado { get; set; }
        [XmlElement(ElementName = "AdicionaisVolume", Namespace = "http://www.visualset.inf.br/")]
        public string AdicionaisVolume { get; set; }
        [XmlElement(ElementName = "VlrACobrar", Namespace = "http://www.visualset.inf.br/")]
        public string VlrACobrar { get; set; }
        [XmlElement(ElementName = "Etiqueta", Namespace = "http://www.visualset.inf.br/")]
        public string Etiqueta { get; set; }
    }
}
