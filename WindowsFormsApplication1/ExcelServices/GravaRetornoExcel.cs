using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using IntegradorWebService.VIPP;
using System.Windows;

namespace IntegradorWebService.ExcelServices
{
    class GravaRetornoExcel
    {
        public static void GravaRetorno()
        {
            #region Salva a lista de retorno no Excel
            Excel.Application xlsApp = new Excel.Application();
            Excel.Workbook xlsWorkbook = xlsApp.Workbooks.Open(Form1.path, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "", false, false, 0, false, false, false);
            Excel.Worksheet newWorksheetErro;
            Excel.Worksheet newWorksheetOk;

            try
            {
                //Add a worksheet to the workbook.
                newWorksheetErro = xlsApp.Worksheets.Add();
                newWorksheetOk = xlsApp.Worksheets.Add();


                newWorksheetErro.Name = "WebServiceVipp - Erros";

                //Name the sheet.
                newWorksheetOk.Name = "WebServiceVipp - ok";

                //Get the Cells collection.
                Excel.Sheets xlsSheets = xlsWorkbook.Worksheets;

                //For que acessa todas as planilhas
                foreach (Excel.Worksheet xlsWorksheet in xlsSheets)
                {
                    //Acessa a aba da Planilha com o nome "WebServiceVipp"
                    if (xlsWorksheet.Name.Trim().Equals("WebServiceVipp - ok"))
                    {
                        Excel.Range xlsWorksRows = xlsWorksheet.Cells;
                        int cont = 0;
                        foreach (RetornoValida list in Retorno.lRetornoValida)
                        {
                            cont++;
                            xlsWorksRows.Item[cont, 1] = list.Observacao;
                            xlsWorksRows.Item[cont, 2] = list.Nome;
                            xlsWorksRows.Item[cont, 3] = list.Status;
                            xlsWorksRows.Item[cont, 4] = list.Etiqueta;
                        }
                    }

                    if (xlsWorksheet.Name.Trim().Equals("WebServiceVipp - Erros"))
                    {
                        Excel.Range xlsWorksRowss = xlsWorksheet.Cells;

                        int cont = 0;
                        foreach (RetornoInvalida list in Retorno.lRetornoInvalida)
                        {
                            cont++;
                            if (!list.Observacao.Equals(string.Empty) || !list.Observacao.Equals(null))
                            {
                                xlsWorksRowss.Item[cont, 1] = list.Observacao;
                                xlsWorksRowss.Item[cont, 2] = list.Nome;
                                xlsWorksRowss.Item[cont, 3] = list.Status;
                                xlsWorksRowss.Item[cont, 4] = list.Erro;
                            }
                        }
                    }

                }
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Não foi possivel gravar o retorno no arquivo processado, verifique se a planilha está bloqueada");
            }

            DateTime saveNow = DateTime.Now;
            string sdf = saveNow.ToString("dd-MM-yyyy_hh-mm");

            string nomeArquivo = Form1.caminhoArquivo + "\\" + Form1.nomeArquivo + " " + sdf + ".xlsx";
            xlsApp.ActiveWorkbook.SaveAs(nomeArquivo);
            xlsApp.Quit();
            #endregion
        }

    }
}

