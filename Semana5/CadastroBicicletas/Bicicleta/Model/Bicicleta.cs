using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoBicicletas.Model
{
    public class Bicicleta
    {
        [Key]
        public int Id { get; set; } 
        [MaxLength(30)]
        [Required]
        public string Modelo { get; set; }
        [MaxLength(30)]
        [Required]
        public string Marca { get; set; }
        [Required]
        public double Valor { get; set; }

    }
}
