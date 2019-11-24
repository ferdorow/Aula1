using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroDeImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        MigrationContext db = new MigrationContext();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext.DisplayName == "Nome")
            {
                if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Usuario já cadastrado");

                if (value.ToString().Contains("Zeca"))
                    return new ValidationResult("Não é possivel registrar o nome!");
            }
            if (validationContext.DisplayName == "DataNascimento")
            {
                var data = DateTime.Parse(value.ToString()); //converte o value que é string em datetime

                if (data >= DateTime.Now.AddYears(-18))
                    return new ValidationResult("Não é possivel cadastrar menores de idade");

                if (data <= DateTime.Now.AddYears(-150))
                    return new ValidationResult("Não é possivel cadastrar vampiros");
            }

            return ValidationResult.Success;

        }
    }
}