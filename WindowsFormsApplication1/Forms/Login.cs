using IntegradorWebService.VIPP;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using IntegradorWebService.Rest;

namespace IntegradorWebService
{
    public partial class Login : Form
    {

        internal static PerfilImportacao Operfil { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

            Operfil = new PerfilImportacao()
            {
                Usuario = txtUsr.Text,
                Token = txtPwd.Text,
                IdPerfil = "5882"
            };

            if (txtUsr.Text.Length < 6)
            {
                MessageBox.Show("O usuário deve conter no minimo 6 caracteres", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPwd.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter no minimo 6 caracteres", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Logar.LogarVipp(txtUsr.Text, txtPwd.Text))
            {
                Hide();
                new Form1().ShowDialog();
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
