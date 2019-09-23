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
        private int idContador = 0;
        public bool LoginSistema(Usuario usuarios)
        {
            return ListaDeUsuarios.Exists(x =>
            x.Login == usuarios.Login
            && x.Senha == usuarios.Senha);
        }
        private List<Usuario> ListaDeUsuarios { get; set; }
        /// <summary>
        /// Metodo usado para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name"= usuario"> Novo usuario que sera adicionado"
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "admin",
                Senha = "admin",
                Id = idContador++            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "hbsis",
                Senha = "proway",
                Id = idContador++
            });

        }

        public void AdicionarUsuario(Usuario parametroUsuario)
        {
            parametroUsuario.Id = idContador++;
            ListaDeUsuarios.Add(parametroUsuario);
        }
        public List<Usuario> RetornaListaDeUsuario()
        {
            //retorna agora somente a lista de usuarios ativos com a expressão "Where(x => x.Ativo)"
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        //<summary>
        /// <summary>
        /// metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoID"></param> Parametro que identifica o usuarui que sera desativado
        public void RemoverUsuarioPorId(int identificadoID)
        {
            //Aqui usamos o metodo FirstOrDefault para localizarnosso usuario dentro da lista
            //com isso consegui desativar as propriedades desativar registros

            ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
    }
}
