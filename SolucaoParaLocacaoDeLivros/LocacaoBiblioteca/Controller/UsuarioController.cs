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
        private LocacaoContext contextDB = new LocacaoContext();
        public bool LoginSistema(Usuario usuarios)
        {
            return contextDB.ListaDeUsuarios.Exists(x =>
            x.Login == usuarios.Login
            && x.Senha == usuarios.Senha);
        }

        /// <summary>
        /// Metodo usado para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name"= usuario"> Novo usuario que sera adicionado"
        public UsuarioController()
        {


        }

        public void AdicionarUsuario(Usuario usuario)
        {
            usuario.Id = contextDB.IdContadorUsuarios++;
            contextDB.ListaDeUsuarios.Add(usuario);
        }
        public List<Usuario> RetornaListaDeUsuario()
        {
            //retorna agora somente a lista de usuarios ativos com a expressão "Where(x => x.Ativo)"
            return contextDB.ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
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

            var usuario = contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID);
            if (usuario != null)
                usuario.Ativo = false;
        }
    }
}
