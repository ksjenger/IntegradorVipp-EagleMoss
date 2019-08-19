using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace IntegradorWebService.Rest
{
    class Logar
    {

        public static bool LogarVipp(string txtUsr, string txtPwd)
        {

            try
            {
                ServicePointManager.Expect100Continue = false;
                if (string.IsNullOrEmpty(IntegradorWebService.Properties.Settings.Default.Site))
                {
                    return false;
                }

                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(IntegradorWebService.Properties.Settings.Default.Site + "/vipp/remoto/LoginRemoto.php");

                ASCIIEncoding encoding = new ASCIIEncoding();

                string postData = "";
                postData += "&Login=" + txtUsr;
                postData += "&Senha=" + txtPwd;

                byte[] data = encoding.GetBytes(postData);
                

                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentLength = data.Length;

                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                JsonRetorno oJsonRetorno = new JavaScriptSerializer().Deserialize<JsonRetorno>(responseString);

                if (oJsonRetorno.Status.Equals("0"))
                {
                    MessageBox.Show(oJsonRetorno.Msg, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (oJsonRetorno.Status.Equals("1"))
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível Acessar o Site, entre em contato com a VisualSet", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
