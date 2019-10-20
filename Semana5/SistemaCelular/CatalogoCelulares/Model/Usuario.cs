using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class Usuario : ControleUsuario
    {
        [Key] //definino como primary key e identity(1,1)
        public int Id { get; set; }
        [MaxLength(50)] //defininos um tamanho maxi para o campo 'Nome' string
        public string Nome { get; set; }
        [MaxLength(30)] //delimitamos tamanho do campo 'Login'
        [Required] //Definimos que este campo é obrigatório
        public string Login { get; set; }
        [MaxLength(30)]//delimitamos tamanho do campo 'Senha'
        [Required] //Definimos que este campo é obrigatório
        public string Senha { get; set; }

    }
}
