using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


namespace WindowsFormsApplication1.Entities
{

    [XmlRoot(ElementName = "PerfilVipp", Namespace = "http://www.visualset.inf.br/")]
    public class PerfilVipp
    {
        [XmlElement(ElementName = "Usuario", Namespace = "http://www.visualset.inf.br/")]
        public string Usuario { get; set; }

        [XmlElement(ElementName = "Token", Namespace = "http://www.visualset.inf.br/")]
        public string Token { get; set; }

        [XmlElement(ElementName = "IdPerfil", Namespace = "http://www.visualset.inf.br/")]
        public string IdPerfil { get; set; }

    }
}
