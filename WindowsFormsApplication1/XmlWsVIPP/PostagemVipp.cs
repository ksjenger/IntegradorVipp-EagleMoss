using IntegradorWebService.XmlWsVIPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using WindowsFormsApplication1.WSVippPostar;
using Servico = IntegradorWebService.XmlWsVIPP.Servico;

namespace IntegradorWebService
{
    [XmlRoot(ElementName = "PostagemVipp", Namespace = "http://www.visualset.inf.br/")]
    public class PostagemVipp
    {
        
        private Destinatario oDestinatario;
        private VolumeObjeto[] oVolumes;

        [XmlElement(ElementName = "PerfilVipp", Namespace = "http://www.visualset.inf.br/")]
        public PerfilVipp PerfilVipp { get; set; }


        [XmlElement(ElementName = "ContratoEct", Namespace = "http://www.visualset.inf.br/")]
        public ContratoEct ContratoEct { get; set; }


        [XmlElement(ElementName = "Destinatario", Namespace = "http://www.visualset.inf.br/")]
        public Destinatario Destinatario { get; set; }


        [XmlElement(ElementName = "Servico", Namespace = "http://www.visualset.inf.br/")]
        public Servico Servico { get; set; }


        [XmlElement(ElementName = "NotasFiscais", Namespace = "http://www.visualset.inf.br/")]
        public NotasFiscais NotasFiscais { get; set; }


        [XmlElement(ElementName = "Volumes", Namespace = "http://www.visualset.inf.br/")]
        public VolumeObjeto[] Volumes { get; set; }


        public PostagemVipp(PerfilVipp perfilVipp, ContratoEct contratoEct, Destinatario destinatario, Servico servico, NotasFiscais notasFiscais, VolumeObjeto[] volumes)
        {
            PerfilVipp = perfilVipp;
            ContratoEct = contratoEct;
            Destinatario = destinatario;
            Servico = servico;
            NotasFiscais = notasFiscais;
            Volumes = volumes;
        }
    }


    

    
    }
    
