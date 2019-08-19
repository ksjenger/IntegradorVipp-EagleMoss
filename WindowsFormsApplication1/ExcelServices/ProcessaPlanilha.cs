using IntegradorWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IntegradorWebService.WSVIPP;
using Excel = Microsoft.Office.Interop.Excel;
using ItemConteudo = IntegradorWebService.WSVIPP.ItemConteudo;
using System.Windows;

namespace IntegradorWebService.Services
{
    class ProcessaPlanilha
    {

        #region Processa Planilha
        public static List<Postagem> ListaDePostagem(string path, Form1 frm)
        {
            #region Recupera a formatação da planilha do Settings.settings
            List<FormatacaoPlanilha> lFormatacao = new List<FormatacaoPlanilha>();
            lFormatacao = FormatacaoPlanilha.ListarFormatacao();
            #endregion
            List<Postagem> lVipp = new List<Postagem>();
            Excel.Application xlsAPP = new Excel.Application();
            int cont = 0;

            try
            {
                Excel.Workbook xlsWorkbook = xlsAPP.Workbooks.Open(path, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "", false, false, 0, false, false, false);
                Excel.Sheets xlsSheets = xlsWorkbook.Worksheets;

                //For que acessa todas as planilhas
                foreach (Excel.Worksheet xlsWorksheet in xlsSheets)
                {
                    //Acessa a aba da Planilha com o nome "Control Respuesta".

                    Excel.Range xlsWorksRows = xlsWorksheet.Rows;

                    //for do Numero de linhas
                    foreach (Excel.Range xlsWorkCell in xlsWorksRows)
                    {
                        Destinatario oDestinatario = new Destinatario();
                        Servico oServico = new Servico();
                        WSVIPP.NotaFiscal[] oNotaFiscal = new NotaFiscal[] { new NotaFiscal() };
                        WSVIPP.VolumeObjeto[] oVolumeObjetos = new WSVIPP.VolumeObjeto[] { new WSVIPP.VolumeObjeto() };
                        ItemConteudo[] oItemConteudos;
                        DeclaracaoConteudo[] oDeclaracaoConteudos = new DeclaracaoConteudo[] { new DeclaracaoConteudo() };
                        Excel.Range xlsCell = xlsWorkCell.Cells;
                        int quantidade = 0;


                        #region Lista de Formatação
                        //For para percorrer a lista de Formatação

                        foreach (FormatacaoPlanilha list in lFormatacao)
                        {
                            String atributo = list.NomeAtributo;
                            int coluna = list.Coluna;
                            Excel.Range AtributoValor = xlsCell.Item[coluna];
                            string valor = AtributoValor.Text;

                            if (atributo.Equals("UF"))
                            {
                                oDestinatario.UF = valor;
                            }

                            if (atributo.Equals("Destinatario"))
                            {
                                oDestinatario.Nome = valor;
                            }
                            else if (atributo.Equals("Endereco"))
                            {
                                oDestinatario.Endereco = valor;
                            }
                            else if (atributo.Equals("Numero"))
                            {
                                oDestinatario.Numero = valor;
                            }
                            else if (atributo.Equals("Bairro"))
                            {
                                oDestinatario.Bairro = valor;
                            }
                            else if (atributo.Equals("Cidade"))
                            {
                                oDestinatario.Cidade = valor;
                            }
                            else if (atributo.Equals("CEP"))
                            {
                                oDestinatario.Cep = valor;
                            }

                            else if (atributo.Equals("NF"))
                            {
                                oNotaFiscal[0].NrNotaFiscal = valor;
                            }

                            else if (atributo.Equals("Complemento"))
                            {
                                oDestinatario.Complemento = valor;
                            }
                            else if (atributo.Equals("Conteudo"))
                            {

                                ItemConteudo oItemConteudo = new ItemConteudo()
                                {
                                    DescricaoConteudo = valor,
                                    Quantidade = 1,
                                    Valor = "100"

                                };

                                oItemConteudos = new ItemConteudo[] { oItemConteudo };
                                oVolumeObjetos[0].DeclaracaoConteudo = new DeclaracaoConteudo()
                                {
                                    ItemConteudo = oItemConteudos,
                                    PesoTotal = 10
                                };

                            }
                            else if (atributo.Equals("Observacao1"))
                            {
                                WSVIPP.VolumeObjeto oVolumeObjeto = new WSVIPP.VolumeObjeto
                                {
                                    CodigoBarraVolume = "IMP FECHADO PODE SER ABERTO ECT"
                                };
                                oVolumeObjetos[0].CodigoBarraVolume = oVolumeObjeto.CodigoBarraVolume;

                            }
                            else if (atributo.Equals("Quantidade"))
                            {
                                try
                                {
                                    quantidade = int.Parse(valor);
                                }
                                catch (System.FormatException)
                                {
                                    quantidade = 0;
                                }
                            }

                            else if (atributo.Equals("DocumentoDestinatario"))
                            {
                                oVolumeObjetos[0].DeclaracaoConteudo.DocumentoDestinatario = valor;
                            }

                            else if (atributo.Equals("Servico"))
                            {
                                string servico = valor;

                                if (valor.Equals("PAC"))
                                {
                                    oServico.ServicoECT = "4669";
                                }
                                else if (valor.Equals("SEDEX"))
                                {
                                    oServico.ServicoECT = "4162";
                                }
                                else
                                {
                                    oServico.ServicoECT = valor;
                                }
                            }

                        }//fim do For da Lista de Formatacao
                        #endregion


                        Postagem oPostagem = new Postagem()
                        {
                            Destinatario = oDestinatario,
                            Volumes = oVolumeObjetos,
                            Servico = oServico,
                            NotasFiscais = oNotaFiscal
                            
                        };

                        lVipp.Add(oPostagem);
                        cont++;
                        frm.labelProgresso.Text = "Processando o item " + cont + " da lista";

                        if (oPostagem.Destinatario.Nome.Equals(string.Empty))
                        {
                            break;
                        }

                    }// fim do for que acessa as linhas

                }// fim do For que acessa todas as planilhas
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro com o arquivo, o mesmo é invalido ou está mal formatado");
            }
            finally
            {
                frm.Close();
                GC.Collect();
            }

            xlsAPP.Quit();
            return lVipp;

        }
        #endregion


    }
}
