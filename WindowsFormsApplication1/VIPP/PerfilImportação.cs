using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegradorWebService.VIPP
{
    class PerfilImportação
    {
        public string Usuario { get; set; }

        public string Token { get; set; }

        public string IdPerfil { get; set; }

        public PerfilImportação()
        {
            Usuario = "testezvp123";
            Token = "testezvp123";
            IdPerfil = "5882";
        }
    }
}
