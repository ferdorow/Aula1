using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialmente devemos deixar a classe pública
    public class Cerveja
    {
        [Key] //Chave primaria, auto incrementada (Ctrl . ou na seta)
        public int Id { get; set; }
        //Aqui definimos a quantidade maxima de caracteres para o nosso campo "Nome"
        //dentro do banco
        [StringLength(50)]
        [Required]  //Identifica que este campo é obrigatório
        public string Nome { get; set; }
        [StringLength(30)] //Tamanho maximo  de caracteres para o tipo
        public string Tipo { get; set; }
        public double Teor { get; set; }

    }
}
