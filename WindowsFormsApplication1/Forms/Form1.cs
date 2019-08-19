using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using IntegradorWebService.Services;
using IntegradorWebService.WSVIPP;
using IntegradorWebService.ExcelServices;
using IntegradorWebService.VIPP;

namespace IntegradorWebService
{
    public partial class Form1 : Form
    {

        List<Postagem> lVipp = new List<Postagem>();

        public static string path;
        public static string nomeArquivo;
        public static string caminhoArquivo;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string mensagem)
        {
            InitializeComponent();
            this.labelProgresso.Text = mensagem;
        }


        void BtnSelecione_Click(object sender, EventArgs e)
        {
            #region Serialização do arquivo XML 
            /*
            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<FormatacaoPlanilha>));
            var subReq = new List<FormatacaoPlanilha>();

            using (var sww = new StringWriter())
            {
               using (XmlWriter writer = XmlWriter.Create(sww))
               {
                   xsSubmit.Serialize(writer, lFormatacao);
                   var plainTextBytes = Encoding.UTF8.GetBytes(sww.ToString());
                   string x = Convert.ToBase64String(plainTextBytes);
               }
            }
            */
            #endregion

            #region Abre o Arquivo
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Excel files (*.csv)|*.csv|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    nomeArquivo = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    caminhoArquivo = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    labelPath.Text = path;
                    labelProgresso.Text = "Importando o Arquivo";
                    lVipp = ProcessaPlanilha.ListaDePostagem(path, this);
                    labelProgresso.Text = "Arquivo importado!";

                    #region Chama o metodo para Postar Objeto
                    VIPP.PostarObjeto.Postagem(lVipp, this);
                    #endregion

                    labelProgresso.Text = "Salvando o arquivo processado...";
                    GravaRetornoExcel.GravaRetorno();
                    MessageBox.Show("Importação finalizada!");
                }
                else
                {
                    Hide();
                    new Form1().ShowDialog();
                }
            }

            #endregion
           //GC.Collect();
            //Close();

        }

    }
}
