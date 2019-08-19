using IntegradorWebService.WSVIPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml;
using IntegradorWebService.VIPP;

namespace IntegradorWebService.VIPP
{
    class PostarObjeto
    {

        public List<string> lRetorno = new List<string>();

        #region Recebe a lista, Faz a chamada no Web Service. O metodo faz outra chamada para guardar o retorno em 2 listas
        public static void Postagem(List<Postagem> lVipp, Form1 frm)
        {
            string oRetorno = null;
            int cont = 0;

            foreach (Postagem o in lVipp)
            {
                cont++;
                frm.labelProgresso.Text = "Transmitindo para o VIPP o objeto " + cont + " da lista";
                Postagem oPostagem = new Postagem
                {
                    Destinatario = o.Destinatario,
                    ContratoEct = o.ContratoEct,
                    NotasFiscais = o.NotasFiscais,
                    PerfilVipp = new PerfilVipp(),
                    Servico = o.Servico,
                    Volumes = o.Volumes,
                };
                PerfilImportacao perfil = Login.Operfil;
                oPostagem.PerfilVipp.Usuario = perfil.Usuario;
                oPostagem.PerfilVipp.Token = perfil.Token;
                oPostagem.PerfilVipp.IdPerfil = perfil.IdPerfil;

                PostagemVipp oSigep = new PostagemVipp();
                try
                {
                    oRetorno = oSigep.PostarObjeto(oPostagem).InnerXml;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e.Message + " verifique a conexao com a Internet");
                }
                Retorno.RetornoPostagem(oRetorno, frm);
                #endregion

            }
        }
    }
}