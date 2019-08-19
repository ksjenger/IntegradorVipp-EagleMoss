using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace IntegradorWebService
{
    public class FormatacaoPlanilha
    {
        #region Atributos
        public string NomeAtributo { get; set; }
        public int Coluna { get; set; }
        #endregion

        #region Construtores
        public FormatacaoPlanilha()
        {
            NomeAtributo = string.Empty;
            Coluna = int.MinValue;
        }
        #endregion

        #region Validacao
        public static List<FormatacaoPlanilha> ListarFormatacao()
        {
            List<FormatacaoPlanilha> lista = new List<FormatacaoPlanilha>();

            //string layout = IntegradorWebService.Properties.Settings.Default.Layout;
            string layout = WindowsFormsApplication1.Properties.Settings.Default.Layout;
            char[] charsToTrim = { '"', ' ', '\\'};
            layout = layout.Trim(charsToTrim);
            byte[] data = Convert.FromBase64String(layout.Trim());
            string decodedString = Encoding.UTF8.GetString(data);
            XElement xmlElement = XElement.Parse(decodedString);
            var xml = xmlElement;

            var q = from e in xml.Descendants("FormatacaoPlanilha")
                    select new FormatacaoPlanilha()
                    {
                        NomeAtributo = e.Element("NomeAtributo").Value,
                        Coluna = int.Parse(e.Element("Coluna").Value)
            };


            foreach (var k in q)
            {
                lista.Add(k);
            }

            return lista;
        }

        #endregion
    }
}