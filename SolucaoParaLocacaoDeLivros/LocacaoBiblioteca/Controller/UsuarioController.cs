using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
    ///<summary>
    ///Metodo que realiza o login dentro do nosso sistema
    ///Para realizar o login padrão use
    ///Login:Admin
    ///Senha:Admin
    ///<summary>
    ///<paraname> = "Usuario"> Passamos um objeto d nome Usuario como parametro </param>
    ///<returns> Retorna verdadeiro quando existir usuario e senha    

{
    public class UsuarioController
    {
        public bool LoginSistema(Usuario usuarios)
        {
            if (usuarios.Login == "Admin" && usuarios.Senha == "Admin")
                return true;
            else
                return false;
        }
        public List<Usuario> Usuario { get; set; }
        public UsuarioController()
        {
            Usuario = new List<Usuario>();

            Usuario.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin",
            });
            Usuario.Add(new Usuario()
            {
                Login = "hbsis",
                Senha = "proway",
            });

        }
        public bool loginSistema(Usuario usuario)
        {
            return Usuario.Exists(x =>
            x.Login == usuario.Login
            && x.Senha == usuario.Senha);
        }
    }
}
