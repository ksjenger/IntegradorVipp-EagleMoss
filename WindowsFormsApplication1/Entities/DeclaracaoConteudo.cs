using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WindowsFormsApplication1.Entities
{
    [XmlRoot(ElementName = "DeclaracaoConteudo", Namespace = "http://www.visualset.inf.br/")]
    public class DeclaracaoConteudo : IConvertible
    {
        [XmlElement(ElementName = "DocumentoRemetente", Namespace = "http://www.visualset.inf.br/")]
        public string DocumentoRemetente { get; set; }
        [XmlElement(ElementName = "DocumentoDestinatario", Namespace = "http://www.visualset.inf.br/")]
        public string DocumentoDestinatario { get; set; }
        [XmlElement(ElementName = "PesoTotal", Namespace = "http://www.visualset.inf.br/")]
        public int PesoTotal { get; set; }
        [XmlElement(ElementName = "ItemConteudo", Namespace = "http://www.visualset.inf.br/")]
        public ItemConteudo[] ItemConteudo { get; set; }

        public DeclaracaoConteudo(ItemConteudo[] ItemConteudo)
        {
            this.ItemConteudo = ItemConteudo;
        }

        public DeclaracaoConteudo()
        {
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }
}
