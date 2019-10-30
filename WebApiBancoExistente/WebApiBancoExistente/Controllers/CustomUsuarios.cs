using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class UsuariosController
    {
        private DataBaseContext db = new DataBaseContext();

        [HttpGet]
        [Route("Api/Usuarios/CustomQuery")]
        public object CustomUsuariosQuery()
        {
            var listaDeusuarios = db.Usuarios.ToList();

            var retornoUsuarios = from usu in listaDeusuarios
                                  select new
                                  {
                                      NomeUsuario = usu.Usuario1,
                                      UsuarioId = usu.Id
                                  };

            return retornoUsuarios;
        }
    }
}