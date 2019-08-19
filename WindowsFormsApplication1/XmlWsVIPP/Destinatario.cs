using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegradorWebService.XmlWsVIPP
{
    [XmlRoot(ElementName = "Destinatario")]
    public class Destinatario
    {
        [XmlElement(ElementName = "CnpjCpf")]
        public string CnpjCpf { get; set; }
        [XmlElement(ElementName = "IeRg")]
        public string IeRg { get; set; }
        [XmlElement(ElementName = "Nome")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "SegundaLinhaDestinatario")]
        public string SegundaLinhaDestinatario { get; set; }
        [XmlElement(ElementName = "Endereco")]
        public string Endereco { get; set; }
        [XmlElement(ElementName = "Numero")]
        public string Numero { get; set; }
        [XmlElement(ElementName = "Complemento")]
        public string Complemento { get; set; }
        [XmlElement(ElementName = "Bairro")]
        public string Bairro { get; set; }
        [XmlElement(ElementName = "Cidade")]
        public string Cidade { get; set; }
        [XmlElement(ElementName = "UF")]
        public string UF { get; set; }
        [XmlElement(ElementName = "Cep")]
        public string Cep { get; set; }
        [XmlElement(ElementName = "Telefone")]
        public string Telefone { get; set; }
        [XmlElement(ElementName = "Celular")]
        public string Celular { get; set; }
        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }
    }
}
