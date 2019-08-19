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

    [XmlRoot(ElementName = "Servico")]
    public class Servico
    {
        [XmlElement(ElementName = "ServicoECT")]
        public string ServicoECT { get; set; }
    }

    [XmlRoot(ElementName = "NotaFiscal")]
    public class NotaFiscal
    {
        [XmlElement(ElementName = "DtNotaFiscal")]
        public string DtNotaFiscal { get; set; }
        [XmlElement(ElementName = "SerieNotaFiscal")]
        public string SerieNotaFiscal { get; set; }
        [XmlElement(ElementName = "NrNotaFiscal")]
        public string NrNotaFiscal { get; set; }
        [XmlElement(ElementName = "VlrTotalNota")]
        public string VlrTotalNota { get; set; }
    }

    [XmlRoot(ElementName = "NotasFiscais")]
    public class NotasFiscais
    {
        [XmlElement(ElementName = "NotaFiscal")]
        public NotaFiscal NotaFiscal { get; set; }
    }

    [XmlRoot(ElementName = "VolumeObjeto")]
    public class VolumeObjeto
    {
        [XmlElement(ElementName = "Peso")]
        public string Peso { get; set; }
        [XmlElement(ElementName = "Cubagem")]
        public string Cubagem { get; set; }
        [XmlElement(ElementName = "Altura")]
        public string Altura { get; set; }
        [XmlElement(ElementName = "Largura")]
        public string Largura { get; set; }
        [XmlElement(ElementName = "Comprimento")]
        public string Comprimento { get; set; }
        [XmlElement(ElementName = "ContaLote")]
        public string ContaLote { get; set; }
        [XmlElement(ElementName = "ChaveRoteamento")]
        public string ChaveRoteamento { get; set; }
        [XmlElement(ElementName = "CodigoBarraVolume")]
        public string CodigoBarraVolume { get; set; }
        [XmlElement(ElementName = "CodigoBarraCliente")]
        public string CodigoBarraCliente { get; set; }
        [XmlElement(ElementName = "ObservacaoVisual")]
        public string ObservacaoVisual { get; set; }
        [XmlElement(ElementName = "ObservacaoQuatro")]
        public string ObservacaoQuatro { get; set; }
        [XmlElement(ElementName = "ObservacaoCinco")]
        public string ObservacaoCinco { get; set; }
        [XmlElement(ElementName = "PosicaoVolume")]
        public string PosicaoVolume { get; set; }
        [XmlElement(ElementName = "Conteudo")]
        public string Conteudo { get; set; }
        [XmlElement(ElementName = "ValorDeclarado")]
        public string ValorDeclarado { get; set; }
        [XmlElement(ElementName = "AdicionaisVolume")]
        public string AdicionaisVolume { get; set; }
        [XmlElement(ElementName = "VlrACobrar")]
        public string VlrACobrar { get; set; }
        [XmlElement(ElementName = "Etiqueta")]
        public string Etiqueta { get; set; }
        [XmlElement(ElementName = "ValorTarifa")]
        public string ValorTarifa { get; set; }
        [XmlElement(ElementName = "ValorAdicionais")]
        public string ValorAdicionais { get; set; }
        [XmlElement(ElementName = "ValorPostagem")]
        public string ValorPostagem { get; set; }
        [XmlElement(ElementName = "StEntregaSabado")]
        public string StEntregaSabado { get; set; }
        [XmlElement(ElementName = "StEntregaDomiciliar")]
        public string StEntregaDomiciliar { get; set; }
        [XmlElement(ElementName = "DiasUteisPrazo")]
        public string DiasUteisPrazo { get; set; }
    }

    [XmlRoot(ElementName = "Volumes")]
    public class Volumes
    {
        [XmlElement(ElementName = "VolumeObjeto")]
        public VolumeObjeto VolumeObjeto { get; set; }
    }

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

    [XmlRoot(ElementName = "ListaErros")]
    public class ListaErros
    {
        [XmlElement(ElementName = "Erro")]
        public List<Erro> Erro { get; set; }
    }

    [XmlRoot(ElementName = "Postagem")]
    public class Postagem
    {
        [XmlElement(ElementName = "ContratoEct")]
        public ContratoEct ContratoEct { get; set; }
        [XmlElement(ElementName = "Destinatario")]
        public Destinatario Destinatario { get; set; }
        [XmlElement(ElementName = "Servico")]
        public Servico Servico { get; set; }
        [XmlElement(ElementName = "NotasFiscais")]
        public NotasFiscais NotasFiscais { get; set; }
        [XmlElement(ElementName = "Volumes")]
        public Volumes Volumes { get; set; }
        [XmlElement(ElementName = "ListaErros")]
        public ListaErros ListaErros { get; set; }
        [XmlElement(ElementName = "StatusPostagem")]
        public string StatusPostagem { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

}
