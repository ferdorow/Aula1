using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class ControleUsuario
    {
        //Definimos o campo com o valor default 'true' para nossos registros
        public bool Ativo { get; set; } = true;
        //Definimos 0 para o usuario criado pelo sistema sem usuario logado
        public int UsuarioCriacao { get; set; } = 0;
        //Definimos para alteracao do sistema quando nao logado usuario 0
        public int UsuarioAlteracao { get; set; } = 0;
        //setamos nossa data de criacao atual pela classe DateTime
        public DateTime Datacriacao { get; set; } = DateTime.Now;
        //Aqui definimos quando nao informado para data de alteracao e a data atual
        public DateTime DatAlteracao { get; set; } = DateTime.Now;

    }
}
