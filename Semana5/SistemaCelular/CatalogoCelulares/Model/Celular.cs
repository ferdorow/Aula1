using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //deixamos a classe publica
    public class Celular : ControleUsuario
    {
        [Key]  //Chave primaria
        public int Id { get; set; }
        [MaxLength(30)]//Definicao de tamanho maximo do campo
        [Required] //Definimos campo obrigatório
        public string Marca { get; set; }
        [MaxLength(30)] //Definicao de tamanho maximo do campo
        [Required] //Definimos campo obrigatório
        public string Modelo { get; set; }
        [Required] //Definimos campo obrigatório
        public double Preco { get; set; }
    }
}
